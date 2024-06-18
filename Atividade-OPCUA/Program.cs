using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace Atividade_OPCUA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var config = CreateConfiguration();
            config.Validate(ApplicationType.Server).Wait();

            ApplicationInstance application = new ApplicationInstance(config);

            Console.WriteLine("Hello World!");
            try
            {
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                application.Start(new LevelPlantServer()).Wait();

                Console.ReadKey(true);

                Console.WriteLine("Good Bye World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            
        }

        static ApplicationConfiguration CreateConfiguration()
        {
            var config = new ApplicationConfiguration
            {
                ApplicationName = "MyOpcUaServer",
                ApplicationUri = "urn:localhost:MyOpcUaServer",
                ApplicationType = ApplicationType.Server,
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = CertificateStoreType.Directory,
                        StorePath = "pki/own",
                        SubjectName = "CN=WilliamHenrique, O=UFCG, C=US"
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
                ServerConfiguration = new ServerConfiguration
                {
                    BaseAddresses = { "opc.tcp://localhost:8081/" },
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
    }
}