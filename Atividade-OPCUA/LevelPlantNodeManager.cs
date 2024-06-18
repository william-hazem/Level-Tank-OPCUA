using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;
using yourorganisation.org.Planta;

namespace Atividade_OPCUA
{
    
    internal class LevelPlantNodeManager : CustomNodeManager2
    {
        private LevelPlantServerConfiguration m_configuration;
        private static TanqueTypeState mLevelTank1;
        public LevelPlantNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration) 
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta;
            namespaceUrls[1] = yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<LevelPlantServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new LevelPlantServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "C:\\Users\\WilliamHenrique\\source\\repos\\Atividade-OPCUA\\Atividade-OPCUA\\Model\\yourorganisation.org.Planta.PredefinedNodes.uanodes",
                typeof(LevelPlantServerConfiguration).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            //base.CreateAddressSpace(externalReferences);
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(yourorganisation.org.Planta.Objects.Tanque1, base.NamespaceIndexes[0]), typeof(BaseObjectState));
                
                mLevelTank1 = new TanqueTypeState(null);
                mLevelTank1.Create(SystemContext, passiveNode);

                AddPredefinedNode(SystemContext, mLevelTank1);
            }
        }


    }
}
