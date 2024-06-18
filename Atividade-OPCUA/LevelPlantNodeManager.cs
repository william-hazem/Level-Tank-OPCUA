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
        private static TanqueTypeState mLevelTank2;
        private static TanqueTypeState mLevelTank3;
        private static TanqueTypeState mLevelTank4;


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
                BaseObjectState passiveNode2 = (BaseObjectState)FindPredefinedNode(new NodeId(yourorganisation.org.Planta.Objects.Tanque2, base.NamespaceIndexes[0]), typeof(BaseObjectState));
                BaseObjectState passiveNode3 = (BaseObjectState)FindPredefinedNode(new NodeId(yourorganisation.org.Planta.Objects.Tanque3, base.NamespaceIndexes[0]), typeof(BaseObjectState));
                BaseObjectState passiveNode4 = (BaseObjectState)FindPredefinedNode(new NodeId(yourorganisation.org.Planta.Objects.Tanque4, base.NamespaceIndexes[0]), typeof(BaseObjectState));

                mLevelTank1 = new TanqueTypeState(null);
                mLevelTank1.Create(SystemContext, passiveNode);

                mLevelTank2 = new TanqueTypeState(null);
                mLevelTank2.Create(SystemContext, passiveNode2);

                mLevelTank3 = new TanqueTypeState(null);
                mLevelTank3.Create(SystemContext, passiveNode3);

                mLevelTank4 = new TanqueTypeState(null);
                mLevelTank4.Create(SystemContext, passiveNode4);

                AddPredefinedNode(SystemContext, mLevelTank1);
                AddPredefinedNode(SystemContext, mLevelTank2);
                AddPredefinedNode(SystemContext, mLevelTank3);
                AddPredefinedNode(SystemContext, mLevelTank4);

            }
        }


    }
}
