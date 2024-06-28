using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using TankClient;
using Opc.Ua.Client;

namespace TankClientUI
{
    public partial class ClientScreen : Form
    {
        private readonly UAClient uaClient;
        private Subscription subscription;
        private TabPageTextWriter m_console;

        public ClientScreen()
        {
            InitializeComponent();
            m_console = new TabPageTextWriter(tpConsole, tbConsole);
            uaClient = new UAClient(CreateConfiguration(), m_console, ClientBase.ValidateResponse)
            {
                AutoAccept = true,
                SessionLifeTime = 60_000,
            };

            //pbLogo.ImageLocation = "assets/mu.jpeg";
        }

        private void ClientScreen_Load(object sender, EventArgs e)
        {
            var tabPageTextWriter = new TabPageTextWriter(tpConsole, tbConsole);
            //Console.SetOut(tabPageTextWriter);
        }

        static Opc.Ua.ApplicationConfiguration CreateConfiguration()
        {
            return new Opc.Ua.ApplicationConfiguration
            {
                ApplicationName = "Tank Client",
                ApplicationUri = $"urn:LIEC:InformationModelClient",
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
                        $"opc.tcp://localhost"
                    },
                },
                TransportQuotas = new TransportQuotas(),
                TraceConfiguration = new TraceConfiguration
                {
                    OutputFilePath = "Logs\\OpcUaServer.log",
                    TraceMasks = 515
                }
            };
        }

        /// <summary>
        /// Button click handler, initialize server connection and subscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (uaClient.Session == null || uaClient.Session.Connected != true)
            {
                uaClient.ConnectAsync(serverUrl: tbEndpoint.Text, useSecurity: false).Wait();
                if (uaClient.Session != null && uaClient.Session.Connected)
                {
                    subscription = new Subscription(uaClient.Session.DefaultSubscription)
                    {
                        PublishingInterval = 1000
                    };
                    uaClient.Session.AddSubscription(subscription);
                    subscription.Create();

                    tbEndpoint.ForeColor = Color.Green;
                    BrowseAndAddNodes(ObjectIds.ObjectsFolder, null);
                }
                else
                {
                    tbEndpoint.ForeColor = Color.Red;
                }
            }

        }

        private void BrowseAndAddNodes(NodeId nodeId, TreeNode parentTreeNode)
        {
            ReferenceDescriptionCollection references;
            byte[] continuationPoint;
            uaClient.Session.Browse(
                null,
                null,
                nodeId,
                0u,
                BrowseDirection.Forward,
                ReferenceTypeIds.HierarchicalReferences,
                true,
                (uint)NodeClass.Object | (uint)NodeClass.Variable,
                out continuationPoint,
                out references);

            foreach (var reference in references)
            {
                var childNodeId = (NodeId)ExpandedNodeId.ToNodeId(reference.NodeId, uaClient.Session.NamespaceUris);

                // Check if the namespace index is 2
                if (childNodeId.NamespaceIndex != 2)
                {
                    continue;
                }

                var node = uaClient.Session.ReadNode(childNodeId);
                

                var treeNode = new CustomTreeNode(node.DisplayName.Text, node.NodeClass.ToString(), "null", BuiltInType.Null)
                {
                    Tag = childNodeId
                };

                //if (node.NodeClass == NodeClass.Variable)
                //    treeNode.Text = $"{node.DisplayName.Text} : {node.NodeClass.ToString()}";

                if (parentTreeNode == null)
                {
                    treeViewNodes.Nodes.Add(treeNode);
                }
                else
                {
                    parentTreeNode.Nodes.Add(treeNode);
                }

                // If it's a variable, create a monitored item
                if (node.NodeClass == NodeClass.Variable)
                {
                    treeNode.BuiltinType = uaClient.Session.ReadValue(childNodeId).WrappedValue.TypeInfo.BuiltInType;
                    treeNode.NodeType = treeNode.BuiltinType.ToString();
                    CreateMonitoredItem(childNodeId, treeNode);
                }

                // Recursively browse children
                BrowseAndAddNodes(childNodeId, treeNode);

                m_console.WriteLine($"reference.NodeId: {reference.NodeId} | {childNodeId} | {node.GetType()} | {node.TypeId}");
            }
        }
        private void CreateMonitoredItem(NodeId nodeId, CustomTreeNode treeNode)
        {
            var monitoredItem = new MonitoredItem(subscription.DefaultItem)
            {
                StartNodeId = nodeId,
                AttributeId = Attributes.Value,
                DisplayName = nodeId.ToString(),
                SamplingInterval = 1000
            };

            monitoredItem.Notification += (monitoredItemNotification, args) =>
            {
                var value = ((MonitoredItemNotification)args.NotificationValue).Value.WrappedValue;
                UpdateTreeNodeValue(treeNode, value.ToString());
            };

            subscription.AddItem(monitoredItem);
            subscription.ApplyChanges();
        }

        private void UpdateTreeNodeValue(CustomTreeNode treeNode, string value)
        {
            if (treeNode.TreeView.InvokeRequired)
            {
                treeNode.TreeView.Invoke(new Action(() => treeNode.NodeValue = value.ToString()));
                treeNode.UpdateText();
            }
            else
            {
                treeNode.NodeValue = value.ToString();
            };
        }

        private TextBox editBox;

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CustomTreeNode node = e.Node as CustomTreeNode;
            if (node != null && node.BuiltinType != BuiltInType.Null)
            {
                editBox = new TextBox();
                editBox.Bounds = treeViewNodes.Bounds;
                editBox.Text = node.NodeValue;
                editBox.KeyDown += EditBox_KeyDown;
                editBox.LostFocus += (object sender, EventArgs e) =>
                {
                    treeViewNodes.Controls.Remove(editBox);
                    (sender as TextBox).Dispose();
                };
                treeViewNodes.Controls.Add(editBox);
                editBox.Focus();
            }
        }

        private void EditBox_LostFocus(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustomTreeNode node = treeViewNodes.SelectedNode as CustomTreeNode;
                if (node != null)
                {
                    // write value to OPC Server
                    //uaClient.Session.ReadValue(treeViewNodes.SelectedNode.Tag as NodeId).WrappedValue.type
                    //var value = Convert.ChangeType(editBox.Text, );
                    //m_console.WriteLine("Converting string to {0}", node.BuiltinType);
                    try
                    {
                        var value = TypeInfo.Cast(editBox.Text, node.BuiltinType);
                        WriteValueCollection nodes2write = new WriteValueCollection()
                        {
                            new WriteValue() {
                                NodeId = node.Tag as NodeId,
                                AttributeId = Attributes.Value,
                                Value = new DataValue(new Variant(value))
                            }
                        };
                        StatusCodeCollection results = null;
                        DiagnosticInfoCollection diagnosticInfos;
                        uaClient.Session.Write(
                            null,
                            nodes2write,
                            out results,
                            out diagnosticInfos
                        );

                        foreach (StatusCode writeResult in results)
                        {
                            m_console.WriteLine(" Write Status = {0}", writeResult);
                        }

                        node.NodeValue = editBox.Text;
                        node.UpdateText();
                        treeViewNodes.Controls.Remove(editBox);
                        editBox.Dispose();
                    }
                    catch(FormatException ex)
                    {
                        m_console.WriteLine("Wrong datatype, expected {0}", node.BuiltinType);
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                treeViewNodes.Controls.Remove(editBox);
                editBox.Dispose();
            }
        }

        private void tbConsole_Leave(object sender, EventArgs e)
        {

        }
    }

    public class TabPageTextWriter : TextWriter
    {
        private TabPage _tabPage;
        private TextBox _textBox;

        public TabPageTextWriter(TabPage tabPage, TextBox textBox)
        {
            _tabPage = tabPage;
            _textBox = textBox;
        }

        public override void Write(char value)
        {
            _textBox.AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            _textBox.AppendText(value);
        }
        
        public override void WriteLine(string value)
        {
            _textBox.AppendText(value + "\r\n");
        }

        public override Encoding Encoding => Encoding.Default;
    }
}
