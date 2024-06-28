using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Server;

namespace Atividade_OPCUA
{
    internal class LevelPlantServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new LevelPlantNodeManager(server, configuration));

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties
            {
                ManufacturerName = "LIEC_LARI_EH_OH_OH",
                ProductName = "Planta Nível",
                ProductUri = "LIEC/PlantaNivel/Server/v1.0",
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = Utils.GetAssemblyBuildNumber(),
                BuildDate = Utils.GetAssemblyTimestamp()
            };

            return properties;
        }

        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            server.SessionManager.ImpersonateUser += SessionManager_ImpersonateUser;

            Console.WriteLine($"Servidor Iniciado em {server.EndpointAddresses.First()}");

            
            
        }
        private void SessionManager_ImpersonateUser(Session session, ImpersonateEventArgs args)
        {
            if (args.NewIdentity is UserNameIdentityToken userNameToken)
            {
                // Validate the user identity.
                if (ValidateUser(userNameToken.UserName, userNameToken.DecryptedPassword))
                {
                    args.Identity = new UserIdentity(userNameToken);
                    Console.WriteLine("Authenticated user as {0}", userNameToken.UserName);
                }
                else
                {
                    throw new ServiceResultException(StatusCodes.BadUserAccessDenied, "Invalid username or password.");
                }
                
            }
            else if(args.NewIdentity is AnonymousIdentityToken anonymousIdentityToken) 
            {
                Console.WriteLine("Authenticated Anonymous user");
                return;
            }
            
        }

        private bool ValidateUser(string username, string password)
        {
            // Define valid users.
            var users = new Dictionary<string, string>
            {
                { "william", "123" },
                { "Matheus", "123" }
            };

            // Check if the username and password are valid.
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
