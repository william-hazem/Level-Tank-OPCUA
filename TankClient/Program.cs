using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Client;
using TankClient;
using System.Diagnostics;
using System.Threading;
using System;

namespace Atividade_OPCUA
{
    internal class Program
    {
        private static readonly bool m_verbose = true;
        static string sAppURI = "localhost:4880"; // Default hostname and port
        static ManualResetEvent m_quitEvent = new ManualResetEvent(false);
        static int kMaxSearchDepth = 10;
        static async Task Main(string[] args)
        {
            bool quit = false;
            Console.Write("Hello World!");
            Console.Write("\rEnter Server Endpoint URI: opc.tcp://" + sAppURI);
            Console.Write("\rEnter Server Endpoint URI: opc.tcp://");

            string appuri = Console.ReadLine();
            if (appuri.Length > 0) sAppURI = appuri;

            string serverURI = $"opc.tcp://{sAppURI}/LevelTank/server";

            var config = CreateConfiguration();
            config.Validate(ApplicationType.Client).Wait();

            ApplicationInstance application = new ApplicationInstance(config);

            try
            {
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // wait for timeout or Ctrl-C
                var quitCTS = new CancellationTokenSource();
                Console.CancelKeyPress += (_, eArgs) => {
                    quitCTS.Cancel();
                    m_quitEvent.Set();
                    eArgs.Cancel = true;
                };

                do
                {

                    using (UAClient uaClient = new UAClient(application.ApplicationConfiguration, Console.Out, ClientBase.ValidateResponse)
                    {
                        AutoAccept = true,
                        SessionLifeTime = 60_000,
                    })
                    {
                        bool connected = await uaClient.ConnectAsync(serverURI, false, quitCTS.Token).ConfigureAwait(false);
                        if (connected)
                        {
                            Console.WriteLine("Connected");


                            //// Read values from nodes
                            {// set desired nodes and attributes to be read
                                ReadValueIdCollection tanque1Values = new ReadValueIdCollection()
                                {
                                    // Tanque 1 - Values
                                    new ReadValueId{NodeId="ns=2;i=6025", AttributeId=Attributes.Value},
                                    new ReadValueId{NodeId="ns=2;i=6037", AttributeId=Attributes.Value},
                                    new ReadValueId{NodeId=new NodeId("Tanque1.ControleVazao.MV", 2), AttributeId=Attributes.Value},
                                };

                                // call read service
                                uaClient.Session.Read(
                                    null,
                                    0,  // max age
                                    TimestampsToReturn.Both,
                                    tanque1Values,
                                    out DataValueCollection tanque1Results,
                                    out DiagnosticInfoCollection tanque1Infos
                                    );
                                ClientBase.ValidateResponse(tanque1Results, tanque1Values);

                                foreach (DataValue result in tanque1Results)
                                {
                                    Console.WriteLine("Value = {0}, Status Code = {1}", result.Value, result.StatusCode);
                                }
                            }


                            //// PubSub for all browsed
                            {
                                NodeIdCollection variableIds = null;
                                ReferenceDescriptionCollection referenceDescriptions = null;

                                List<NodeId> tanque1NodeIds = new List<NodeId> {
                                    "ns=2;i=6026",
                                    new NodeId("Tanque1.ControleVazao.MV", 2),
                                };

                                NodeCollection variables = new NodeCollection();

                                referenceDescriptions =
                                        await BrowseFullAddressSpaceAsync(uaClient, Objects.RootFolder).ConfigureAwait(false);
                                variableIds = new NodeIdCollection(referenceDescriptions
                                    .Where(r => r.NodeClass == NodeClass.Variable && r.TypeDefinition.NamespaceIndex != 0)
                                    .Select(r => ExpandedNodeId.ToNodeId(r.NodeId, uaClient.Session.NamespaceUris)));

                                var variableReferences = referenceDescriptions
                                            .Where(r => r.NodeClass == NodeClass.Variable && r.NodeId.NamespaceIndex > 1)
                                            .Select(r => r.NodeId)
                                            //.OrderBy(o => random.Next())
                                            .Take(100) // takes 100 nodes
                                            .ToList();
                                variables.AddRange(uaClient.Session.NodeCache.Find(variableReferences).Cast<Node>());

                                await SubscribeAllValuesAsync(uaClient,
                                        variableIds: new NodeCollection(variables),
                                        samplingInterval: 100,
                                        publishingInterval: 1000,
                                        queueSize: 10,
                                        lifetimeCount: 60,
                                        keepAliveCount: 2).ConfigureAwait(false);
                                // Wait for DataChange notifications from MonitoredItems
                                Console.WriteLine("Subscribed to {0} variables. Press Ctrl-C to exit.", 100);

                                int waitTime = 0;
                                DateTime endTime = waitTime > 0 ? DateTime.UtcNow.Add(TimeSpan.FromMilliseconds(waitTime)) : DateTime.MaxValue;
                                var variableIterator = variables.GetEnumerator();
                                while (!quit && endTime > DateTime.UtcNow)
                                {
                                    //if (variableIterator.MoveNext())
                                    //{
                                    //    try
                                    //    {
                                    //        var value = await uaClient.Session.ReadValueAsync(variableIterator.Current.NodeId).ConfigureAwait(false);
                                    //        Console.WriteLine("Value of {0} is {1}", variableIterator.Current.NodeId, value);
                                    //    }
                                    //    catch (Exception ex)
                                    //    {
                                    //        Console.WriteLine("Error reading value of {0}: {1}", variableIterator.Current.NodeId, ex.Message);
                                    //    }
                                    //}
                                    //else
                                    //{
                                    //    variableIterator = variables.GetEnumerator();
                                    //}
                                    quit = m_quitEvent.WaitOne(500);
                                }
                            }
                            quit = m_quitEvent.WaitOne(30_000);
                            // end connection
                            uaClient.Disconnect(false);
                        }
                        else // !connected
                        {
                            Console.WriteLine("Not connected");
                        }
                    }

                } while (!quit);

                Console.ReadKey(true);

                Console.WriteLine("Good Bye World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
        }

        static ApplicationConfiguration CreateConfiguration()
        {
            var config = new ApplicationConfiguration
            {
                ApplicationName = "Tank Client",
                ApplicationUri = $"urn:{sAppURI}:InformationModelClient",
                ApplicationType = ApplicationType.Client,
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = CertificateStoreType.Directory,
                        StorePath = "pki/own",
                        SubjectName = "CN=LIEC, O=UFCG, C=BR"
                    },
                    TrustedPeerCertificates = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "pki/trusted"
                    },
                    RejectedCertificateStore = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "pki/rejected"
                    },
                    TrustedIssuerCertificates = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "pki/issuers"
                    },
                    AutoAcceptUntrustedCertificates = true,
                    AddAppCertToTrustedStore = true
                },
                ClientConfiguration = new ClientConfiguration
                {
                    WellKnownDiscoveryUrls = new StringCollection
                    {
                        $"opc.tcp://{sAppURI}"
                    },
                },
                ServerConfiguration = new ServerConfiguration
                {
                    BaseAddresses = { $"opc.tcp://{sAppURI}/LevelTank/server" },
                    SecurityPolicies = new ServerSecurityPolicyCollection
                    {
                        new ServerSecurityPolicy
                        {
                            SecurityMode = MessageSecurityMode.None,
                            SecurityPolicyUri = SecurityPolicies.None
                        }
                    },
                    UserTokenPolicies = new UserTokenPolicyCollection
                    {
                        new UserTokenPolicy(UserTokenType.Anonymous)
                    }
                },
                /*TransportQuotas = new TransportQuotas
                {
                    OperationTimeout = 15000,
                    MaxStringLength = 1048576,
                    MaxByteStringLength = 1048576,
                    MaxArrayLength = 65535,
                    MaxMessageSize = 4194304,
                    MaxBufferSize = 65535,
                    ChannelLifetime = 600000,
                    SecurityTokenLifetime = 3600000
                },*/
                TransportQuotas = new TransportQuotas(),
                TraceConfiguration = new TraceConfiguration
                {
                    OutputFilePath = "Logs\\OpcUaServer.log",
                    TraceMasks = 515
                }
            };

            return config;
        }

        /// <summary>
        /// Browse full address space.
        /// </summary>
        /// <param name="uaClient">The UAClient with a session to use.</param>
        /// <param name="startingNode">The node where the browse operation starts.</param>
        /// <param name="browseDescription">An optional BrowseDescription to use.</param>
        static public async Task<ReferenceDescriptionCollection> BrowseFullAddressSpaceAsync(
            IUAClient uaClient,
            NodeId startingNode = null,
            BrowseDescription browseDescription = null,
            CancellationToken ct = default)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Browse template
            const int kMaxReferencesPerNode = 1000;
            var browseTemplate = browseDescription ?? new BrowseDescription
            {
                NodeId = startingNode ?? ObjectIds.RootFolder,
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = ReferenceTypeIds.HierarchicalReferences,
                IncludeSubtypes = true,
                NodeClassMask = 0,
                ResultMask = (uint)BrowseResultMask.All
            };
            var browseDescriptionCollection = CreateBrowseDescriptionCollectionFromNodeId(
                new NodeIdCollection(new NodeId[] { startingNode ?? ObjectIds.RootFolder }),
                browseTemplate);

            // Browse
            var referenceDescriptions = new Dictionary<ExpandedNodeId, ReferenceDescription>();

            int searchDepth = 0;
            uint maxNodesPerBrowse = uaClient.Session.OperationLimits.MaxNodesPerBrowse;
            while (browseDescriptionCollection.Any() && searchDepth < kMaxSearchDepth)
            {
                searchDepth++;
                Utils.LogInfo("{0}: Browse {1} nodes after {2}ms",
                    searchDepth, browseDescriptionCollection.Count, stopWatch.ElapsedMilliseconds);

                BrowseResultCollection allBrowseResults = new BrowseResultCollection();
                bool repeatBrowse;
                BrowseResultCollection browseResultCollection = new BrowseResultCollection();
                BrowseDescriptionCollection unprocessedOperations = new BrowseDescriptionCollection();
                DiagnosticInfoCollection diagnosticsInfoCollection;
                do
                {
                    if (m_quitEvent?.WaitOne(0) == true)
                    {
                        Console.WriteLine("Browse aborted.");
                        break;
                    }

                    var browseCollection = (maxNodesPerBrowse == 0) ?
                        browseDescriptionCollection :
                        browseDescriptionCollection.Take((int)maxNodesPerBrowse).ToArray();
                    repeatBrowse = false;
                    try
                    {
                        var browseResponse = await uaClient.Session.BrowseAsync(null, null,
                            kMaxReferencesPerNode, browseCollection, ct).ConfigureAwait(false);
                        browseResultCollection = browseResponse.Results;
                        diagnosticsInfoCollection = browseResponse.DiagnosticInfos;
                        ClientBase.ValidateResponse(browseResultCollection, browseCollection);
                        ClientBase.ValidateDiagnosticInfos(diagnosticsInfoCollection, browseCollection);

                        // separate unprocessed nodes for later
                        int ii = 0;
                        foreach (BrowseResult browseResult in browseResultCollection)
                        {
                            // check for error.
                            StatusCode statusCode = browseResult.StatusCode;
                            if (StatusCode.IsBad(statusCode))
                            {
                                // this error indicates that the server does not have enough simultaneously active 
                                // continuation points. This request will need to be resent after the other operations
                                // have been completed and their continuation points released.
                                if (statusCode == StatusCodes.BadNoContinuationPoints)
                                {
                                    unprocessedOperations.Add(browseCollection[ii++]);
                                    continue;
                                }
                            }

                            // save results.
                            allBrowseResults.Add(browseResult);
                            ii++;
                        }
                    }
                    catch (ServiceResultException sre)
                    {
                        if (sre.StatusCode == StatusCodes.BadEncodingLimitsExceeded ||
                            sre.StatusCode == StatusCodes.BadResponseTooLarge)
                        {
                            // try to address by overriding operation limit
                            maxNodesPerBrowse = maxNodesPerBrowse == 0 ?
                                (uint)browseCollection.Count / 2 : maxNodesPerBrowse / 2;
                            repeatBrowse = true;
                        }
                        else
                        {
                            Console.WriteLine("Browse error: {0}", sre.Message);
                            throw;
                        }
                    }
                } while (repeatBrowse);

                if (maxNodesPerBrowse == 0)
                {
                    browseDescriptionCollection.Clear();
                }
                else
                {
                    browseDescriptionCollection = browseDescriptionCollection.Skip(browseResultCollection.Count).ToArray();
                }

                // Browse next
                var continuationPoints = PrepareBrowseNext(browseResultCollection);
                while (continuationPoints.Any())
                {
                    if (m_quitEvent?.WaitOne(0) == true)
                    {
                        Console.WriteLine("Browse aborted.");
                    }

                    Utils.LogInfo("BrowseNext {0} continuation points.", continuationPoints.Count);
                    var browseNextResult = await uaClient.Session.BrowseNextAsync(null, false, continuationPoints, ct).ConfigureAwait(false);
                    var browseNextResultCollection = browseNextResult.Results;
                    diagnosticsInfoCollection = browseNextResult.DiagnosticInfos;
                    ClientBase.ValidateResponse(browseNextResultCollection, continuationPoints);
                    ClientBase.ValidateDiagnosticInfos(diagnosticsInfoCollection, continuationPoints);
                    allBrowseResults.AddRange(browseNextResultCollection);
                    continuationPoints = PrepareBrowseNext(browseNextResultCollection);
                }

                // Build browse request for next level
                var browseTable = new NodeIdCollection();
                int duplicates = 0;
                foreach (var browseResult in allBrowseResults)
                {
                    foreach (ReferenceDescription reference in browseResult.References)
                    {
                        if (!referenceDescriptions.ContainsKey(reference.NodeId))
                        {
                            referenceDescriptions[reference.NodeId] = reference;
                            if (reference.ReferenceTypeId != ReferenceTypeIds.HasProperty)
                            {
                                browseTable.Add(ExpandedNodeId.ToNodeId(reference.NodeId, uaClient.Session.NamespaceUris));
                            }
                        }
                        else
                        {
                            duplicates++;
                        }
                    }
                }
                if (duplicates > 0)
                {
                    Utils.LogInfo("Browse Result {0} duplicate nodes were ignored.", duplicates);
                }
                browseDescriptionCollection.AddRange(CreateBrowseDescriptionCollectionFromNodeId(browseTable, browseTemplate));

                // add unprocessed nodes if any
                browseDescriptionCollection.AddRange(unprocessedOperations);
            }

            stopWatch.Stop();

            var result = new ReferenceDescriptionCollection(referenceDescriptions.Values);
            result.Sort((x, y) => (x.NodeId.CompareTo(y.NodeId)));

            Console.WriteLine("BrowseFullAddressSpace found {0} references on server in {1}ms.",
                referenceDescriptions.Count, stopWatch.ElapsedMilliseconds);

            if (m_verbose)
            {
                foreach (var reference in result)
                {
                    Console.WriteLine("NodeId {0} {1} {2}", reference.NodeId, reference.NodeClass, reference.BrowseName);
                }
            }

            return result;
        }

        private static BrowseDescriptionCollection CreateBrowseDescriptionCollectionFromNodeId(
                NodeIdCollection nodeIdCollection,
                BrowseDescription template)
        {
            var browseDescriptionCollection = new BrowseDescriptionCollection();
            foreach (var nodeId in nodeIdCollection)
            {
                BrowseDescription browseDescription = (BrowseDescription)template.MemberwiseClone();
                browseDescription.NodeId = nodeId;
                browseDescriptionCollection.Add(browseDescription);
            }
            return browseDescriptionCollection;
        }

        private static ByteStringCollection PrepareBrowseNext(BrowseResultCollection browseResultCollection)
        {
            var continuationPoints = new ByteStringCollection();
            foreach (var browseResult in browseResultCollection)
            {
                if (browseResult.ContinuationPoint != null)
                {
                    continuationPoints.Add(browseResult.ContinuationPoint);
                }
            }
            return continuationPoints;
        }
        /// <summary>
        /// Subscribe to all variables in the list.
        /// </summary>
        /// <param name="uaClient">The UAClient with a session to use.</param>
        /// <param name="variableIds">The variables to subscribe.</param>
        public static async Task SubscribeAllValuesAsync(
            IUAClient uaClient,
            NodeCollection variableIds,
            int samplingInterval,
            int publishingInterval,
            uint queueSize,
            uint lifetimeCount,
            uint keepAliveCount)
        {
            if (uaClient.Session == null || !uaClient.Session.Connected)
            {
                Console.WriteLine("Session not connected!");
                return;
            }

            try
            {
                // Create a subscription for receiving data change notifications
                var session = uaClient.Session;

                // test for deferred ack of sequence numbers
                session.PublishSequenceNumbersToAcknowledge += DeferSubscriptionAcknowledge;

                // set a minimum amount of three publish requests per session
                session.MinPublishRequestCount = 3;

                // Define Subscription parameters
                Subscription subscription = new Subscription(session.DefaultSubscription)
                {
                    DisplayName = "Console ReferenceClient Subscription",
                    PublishingEnabled = true,
                    PublishingInterval = publishingInterval,
                    LifetimeCount = lifetimeCount,
                    KeepAliveCount = keepAliveCount,
                    SequentialPublishing = true,
                    RepublishAfterTransfer = true,
                    DisableMonitoredItemCache = false,
                    MaxNotificationsPerPublish = 1000,
                    MinLifetimeInterval = (uint)session.SessionTimeout,
                    FastDataChangeCallback = FastDataChangeNotification,
                    FastKeepAliveCallback = FastKeepAliveNotification,
                };
                //Subscription subscription = new Subscription(session.DefaultSubscription);

                //subscription.DisplayName = "Console ReferenceClient Subscription";
                //subscription.PublishingEnabled = true;
                //subscription.PublishingInterval = 1000;
                Console.WriteLine("lifetimecount {0}", subscription.LifetimeCount);
                Console.WriteLine("keepalivecount {0}", subscription.KeepAliveCount);
                Console.WriteLine("publisingInterval {0}", subscription.PublishingInterval);
                Console.WriteLine("sequentialPublishing {0}", subscription.SequentialPublishing);
                Console.WriteLine("publishEnabled {0}", subscription.PublishingEnabled);
                Console.WriteLine("DisableMonitoredItemCache {0}", subscription.DisableMonitoredItemCache);





                session.AddSubscription(subscription);

                // Create the subscription on Server side
                await subscription.CreateAsync().ConfigureAwait(false);
                Console.WriteLine("New Subscription created with SubscriptionId = {0}.", subscription.Id);

                // Create MonitoredItems for data changes
                foreach (Node item in variableIds)
                {
                    MonitoredItem monitoredItem = new MonitoredItem(subscription.DefaultItem);
                    

                        monitoredItem.StartNodeId = item.NodeId;
                        monitoredItem.AttributeId = Attributes.Value;
                        monitoredItem.SamplingInterval = samplingInterval;
                        monitoredItem.DisplayName = item.DisplayName?.Text ?? item.BrowseName?.Name ?? "unknown";
                        monitoredItem.QueueSize = 0;
                        monitoredItem.DiscardOldest = true;
                        monitoredItem.MonitoringMode = MonitoringMode.Reporting;
                        
                    
                    monitoredItem.Notification += OnMonitoredItemNotification;
                    subscription.AddItem(monitoredItem);
                    if (subscription.CurrentKeepAliveCount > 1000) break;
                }

                // Create the monitored items on Server side
                await subscription.ApplyChangesAsync().ConfigureAwait(false);
                Console.WriteLine("MonitoredItems {0} created for SubscriptionId = {1}.", subscription.MonitoredItemCount, subscription.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Subscribe error: {0}", ex.Message);
            }
        }

        private static void FastDataChangeNotification(Subscription subscription, DataChangeNotification notification, IList<string> stringTable)
        {
            
            try
            {
                Console.WriteLine("Notification: Id={0} PublishTime={1} SequenceNumber={2} Items={3}.",
                    subscription.Id, notification.PublishTime,
                    notification.SequenceNumber, notification.MonitoredItems.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("FastDataChangeNotification error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// Handle DataChange notifications from Server
        /// </summary>
        private static void OnMonitoredItemNotification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            Console.WriteLine("Some place!");
            try
            {
                // Log MonitoredItem Notification event
                MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
                Console.WriteLine("Notification: {0} \"{1}\" and Value = {2}.", notification.Message.SequenceNumber, monitoredItem.ResolvedNodeId, notification.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OnMonitoredItemNotification error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// Event handler to defer publish response sequence number acknowledge.
        /// </summary>
        private static void DeferSubscriptionAcknowledge(ISession session, PublishSequenceNumbersToAcknowledgeEventArgs e)
        {
            // for testing keep the latest sequence numbers for a while
            const int AckDelay = 5;
            if (e.AcknowledgementsToSend.Count > 0)
            {
                // defer latest sequence numbers
                var deferredItems = e.AcknowledgementsToSend.OrderByDescending(s => s.SequenceNumber).Take(AckDelay).ToList();
                e.DeferredAcknowledgementsToSend.AddRange(deferredItems);
                foreach (var deferredItem in deferredItems)
                {
                    e.AcknowledgementsToSend.Remove(deferredItem);
                }
            }
        }

        /// <summary>
        /// The fast keep alive notification callback.
        /// </summary>
        private static void FastKeepAliveNotification(Subscription subscription, NotificationData notification)
        {
            try
            {
                Console.WriteLine("Keep Alive  : Id={0} PublishTime={1} SequenceNumber={2}.",
                    subscription.Id, notification.PublishTime, notification.SequenceNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("FastKeepAliveNotification error: {0}", ex.Message);
            }
        }




    }
}