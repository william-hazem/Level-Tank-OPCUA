/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace yourorganisation.org.Planta
{
    #region BombaTypeState Class
    #if (!OPCUA_EXCLUDE_BombaTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BombaTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BombaTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(yourorganisation.org.Planta.ObjectTypes.BombaType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvUGxhbnRhL/////8EYIACAQAAAAEAEQAA" +
           "AEJvbWJhVHlwZUluc3RhbmNlAQHrAwEB6wPrAwAA/////wkAAAAVYIkKAgAAAAEAAgAAAERMAQFxFwAv" +
           "AD9xFwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQACAAAARU4BAXIXAC8AP3IXAAAAAf////8DA///" +
           "//8AAAAAFWCJCgIAAAABAAIAAABMRwEBcxcALwA/cxcAAAAB/////wMD/////wAAAAAVYIkKAgAAAAEA" +
           "AgAAAFNUAQF1FwAvAD91FwAAABv/////AwP/////AAAAAARhggoEAAAAAQAKAAAAU3RhcnRCb21iYQEB" +
           "WRsALwEBWRtZGwAAAQH/////AAAAAARhggoEAAAAAQAJAAAAU3RvcEJvbWJhAQFaGwAvAQFaG1obAAAB" +
           "Af////8AAAAAFWCJCgIAAAABAAQAAABUUklQAQF2FwAvAD92FwAAAAH/////AwP/////AAAAABVgiQoC" +
           "AAAAAQADAAAAVkFMAQGDFwAvAD+DFwAAAAv/////AwP/////AAAAABVgiQoCAAAAAQACAAAAWVMBAXQX" +
           "AC8AP3QXAAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> DL
        {
            get
            {
                return m_dL;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dL, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dL = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> EN
        {
            get
            {
                return m_eN;
            }

            set
            {
                if (!Object.ReferenceEquals(m_eN, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_eN = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> LG
        {
            get
            {
                return m_lG;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lG, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lG = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState ST
        {
            get
            {
                return m_sT;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sT, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sT = value;
            }
        }

        /// <remarks />
        public MethodState StartBomba
        {
            get
            {
                return m_startBombaMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startBombaMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startBombaMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopBomba
        {
            get
            {
                return m_stopBombaMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopBombaMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopBombaMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> TRIP
        {
            get
            {
                return m_tRIP;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tRIP, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tRIP = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> VAL
        {
            get
            {
                return m_vAL;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vAL, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vAL = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> YS
        {
            get
            {
                return m_yS;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yS, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yS = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_dL != null)
            {
                children.Add(m_dL);
            }

            if (m_eN != null)
            {
                children.Add(m_eN);
            }

            if (m_lG != null)
            {
                children.Add(m_lG);
            }

            if (m_sT != null)
            {
                children.Add(m_sT);
            }

            if (m_startBombaMethod != null)
            {
                children.Add(m_startBombaMethod);
            }

            if (m_stopBombaMethod != null)
            {
                children.Add(m_stopBombaMethod);
            }

            if (m_tRIP != null)
            {
                children.Add(m_tRIP);
            }

            if (m_vAL != null)
            {
                children.Add(m_vAL);
            }

            if (m_yS != null)
            {
                children.Add(m_yS);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case yourorganisation.org.Planta.BrowseNames.DL:
                {
                    if (createOrReplace)
                    {
                        if (DL == null)
                        {
                            if (replacement == null)
                            {
                                DL = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                DL = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = DL;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.EN:
                {
                    if (createOrReplace)
                    {
                        if (EN == null)
                        {
                            if (replacement == null)
                            {
                                EN = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                EN = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = EN;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.LG:
                {
                    if (createOrReplace)
                    {
                        if (LG == null)
                        {
                            if (replacement == null)
                            {
                                LG = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                LG = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = LG;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.ST:
                {
                    if (createOrReplace)
                    {
                        if (ST == null)
                        {
                            if (replacement == null)
                            {
                                ST = new BaseDataVariableState(this);
                            }
                            else
                            {
                                ST = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = ST;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.StartBomba:
                {
                    if (createOrReplace)
                    {
                        if (StartBomba == null)
                        {
                            if (replacement == null)
                            {
                                StartBomba = new MethodState(this);
                            }
                            else
                            {
                                StartBomba = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartBomba;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.StopBomba:
                {
                    if (createOrReplace)
                    {
                        if (StopBomba == null)
                        {
                            if (replacement == null)
                            {
                                StopBomba = new MethodState(this);
                            }
                            else
                            {
                                StopBomba = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopBomba;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.TRIP:
                {
                    if (createOrReplace)
                    {
                        if (TRIP == null)
                        {
                            if (replacement == null)
                            {
                                TRIP = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                TRIP = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = TRIP;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.VAL:
                {
                    if (createOrReplace)
                    {
                        if (VAL == null)
                        {
                            if (replacement == null)
                            {
                                VAL = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                VAL = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = VAL;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.YS:
                {
                    if (createOrReplace)
                    {
                        if (YS == null)
                        {
                            if (replacement == null)
                            {
                                YS = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                YS = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = YS;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_dL;
        private BaseDataVariableState<bool> m_eN;
        private BaseDataVariableState<bool> m_lG;
        private BaseDataVariableState m_sT;
        private MethodState m_startBombaMethod;
        private MethodState m_stopBombaMethod;
        private BaseDataVariableState<bool> m_tRIP;
        private BaseDataVariableState<double> m_vAL;
        private BaseDataVariableState<double> m_yS;
        #endregion
    }
    #endif
    #endregion

    #region ControleTypeState Class
    #if (!OPCUA_EXCLUDE_ControleTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControleTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ControleTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(yourorganisation.org.Planta.ObjectTypes.ControleType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvUGxhbnRhL/////8EYIACAQAAAAEAFAAA" +
           "AENvbnRyb2xlVHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wMAAAAVYIkKAgAAAAEAAgAAAE1WAQGI" +
           "FwAvAD+IFwAAAAv/////AwP/////AAAAABVgiQoCAAAAAQACAAAAUFYBAYcXAC8AP4cXAAAAC/////8D" +
           "A/////8AAAAAFWCJCgIAAAABAAIAAABTUAEBhhcALwA/hhcAAAAL/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> MV
        {
            get
            {
                return m_mV;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mV, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mV = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> PV
        {
            get
            {
                return m_pV;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pV, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pV = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> SP
        {
            get
            {
                return m_sP;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sP, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sP = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mV != null)
            {
                children.Add(m_mV);
            }

            if (m_pV != null)
            {
                children.Add(m_pV);
            }

            if (m_sP != null)
            {
                children.Add(m_sP);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case yourorganisation.org.Planta.BrowseNames.MV:
                {
                    if (createOrReplace)
                    {
                        if (MV == null)
                        {
                            if (replacement == null)
                            {
                                MV = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                MV = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = MV;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.PV:
                {
                    if (createOrReplace)
                    {
                        if (PV == null)
                        {
                            if (replacement == null)
                            {
                                PV = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                PV = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = PV;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.SP:
                {
                    if (createOrReplace)
                    {
                        if (SP == null)
                        {
                            if (replacement == null)
                            {
                                SP = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SP = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SP;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_mV;
        private BaseDataVariableState<double> m_pV;
        private BaseDataVariableState<double> m_sP;
        #endregion
    }
    #endif
    #endregion

    #region SensorTypeState Class
    #if (!OPCUA_EXCLUDE_SensorTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SensorTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(yourorganisation.org.Planta.ObjectTypes.SensorType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvUGxhbnRhL/////8EYIACAQAAAAEAEgAA" +
           "AFNlbnNvclR5cGVJbnN0YW5jZQEB7QMBAe0D7QMAAP////8CAAAABGCACgEAAAABAAoAAABCYXNlT2Jq" +
           "ZWN0AQGKEwAvADqKEwAA/////wAAAAAVYIkKAgAAAAEABQAAAFZhbG9yAQF+FwAvAD9+FwAAABj/////" +
           "AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState BaseObject
        {
            get
            {
                return m_baseObject;
            }

            set
            {
                if (!Object.ReferenceEquals(m_baseObject, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_baseObject = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState Valor
        {
            get
            {
                return m_valor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_valor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_valor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_baseObject != null)
            {
                children.Add(m_baseObject);
            }

            if (m_valor != null)
            {
                children.Add(m_valor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case yourorganisation.org.Planta.BrowseNames.BaseObject:
                {
                    if (createOrReplace)
                    {
                        if (BaseObject == null)
                        {
                            if (replacement == null)
                            {
                                BaseObject = new BaseObjectState(this);
                            }
                            else
                            {
                                BaseObject = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = BaseObject;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.Valor:
                {
                    if (createOrReplace)
                    {
                        if (Valor == null)
                        {
                            if (replacement == null)
                            {
                                Valor = new BaseDataVariableState(this);
                            }
                            else
                            {
                                Valor = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = Valor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_baseObject;
        private BaseDataVariableState m_valor;
        #endregion
    }
    #endif
    #endregion

    #region TanqueTypeState Class
    #if (!OPCUA_EXCLUDE_TanqueTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TanqueTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public TanqueTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(yourorganisation.org.Planta.ObjectTypes.TanqueType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvUGxhbnRhL/////8EYIACAQAAAAEAEgAA" +
           "AFRhbnF1ZVR5cGVJbnN0YW5jZQEB7gMBAe4D7gMAAP////8CAAAABGCACgEAAAABAAsAAABCb21iYVRh" +
           "bnF1ZQEBkBMALwEB6wOQEwAA/////wkAAAAVYIkKAgAAAAEAAgAAAERMAQGKFwAvAD+KFwAAAAH/////" +
           "AwP/////AAAAABVgiQoCAAAAAQACAAAARU4BAYsXAC8AP4sXAAAAAf////8DA/////8AAAAAFWCJCgIA" +
           "AAABAAIAAABMRwEBjBcALwA/jBcAAAAB/////wMD/////wAAAAAVYIkKAgAAAAEAAgAAAFNUAQGNFwAv" +
           "AD+NFwAAABv/////AwP/////AAAAAARhggoEAAAAAQAKAAAAU3RhcnRCb21iYQEBXRsALwEBWRtdGwAA" +
           "AQH/////AAAAAARhggoEAAAAAQAJAAAAU3RvcEJvbWJhAQFeGwAvAQFaG14bAAABAf////8AAAAAFWCJ" +
           "CgIAAAABAAQAAABUUklQAQGOFwAvAD+OFwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQADAAAAVkFM" +
           "AQGPFwAvAD+PFwAAAAv/////AwP/////AAAAABVgiQoCAAAAAQACAAAAWVMBAZAXAC8AP5AXAAAAC///" +
           "//8DA/////8AAAAABGCACgEAAAABAA0AAABDb250cm9sZVZhemFvAQGREwAvAQHsA5ETAAD/////AwAA" +
           "ABVgiQoCAAAAAQACAAAATVYBAZEXAC8AP5EXAAAAC/////8DA/////8AAAAAFWCJCgIAAAABAAIAAABQ" +
           "VgEBkhcALwA/khcAAAAL/////wMD/////wAAAAAVYIkKAgAAAAEAAgAAAFNQAQGTFwAvAD+TFwAAAAv/" +
           "////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BombaTypeState BombaTanque
        {
            get
            {
                return m_bombaTanque;
            }

            set
            {
                if (!Object.ReferenceEquals(m_bombaTanque, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_bombaTanque = value;
            }
        }

        /// <remarks />
        public ControleTypeState ControleVazao
        {
            get
            {
                return m_controleVazao;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controleVazao, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controleVazao = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_bombaTanque != null)
            {
                children.Add(m_bombaTanque);
            }

            if (m_controleVazao != null)
            {
                children.Add(m_controleVazao);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case yourorganisation.org.Planta.BrowseNames.BombaTanque:
                {
                    if (createOrReplace)
                    {
                        if (BombaTanque == null)
                        {
                            if (replacement == null)
                            {
                                BombaTanque = new BombaTypeState(this);
                            }
                            else
                            {
                                BombaTanque = (BombaTypeState)replacement;
                            }
                        }
                    }

                    instance = BombaTanque;
                    break;
                }

                case yourorganisation.org.Planta.BrowseNames.ControleVazao:
                {
                    if (createOrReplace)
                    {
                        if (ControleVazao == null)
                        {
                            if (replacement == null)
                            {
                                ControleVazao = new ControleTypeState(this);
                            }
                            else
                            {
                                ControleVazao = (ControleTypeState)replacement;
                            }
                        }
                    }

                    instance = ControleVazao;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BombaTypeState m_bombaTanque;
        private ControleTypeState m_controleVazao;
        #endregion
    }
    #endif
    #endregion
}