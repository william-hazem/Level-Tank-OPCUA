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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace yourorganisation.org.Planta
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint BombaType_StartBomba = 7001;

        /// <remarks />
        public const uint BombaType_StopBomba = 7002;

        /// <remarks />
        public const uint TanqueType_BombaTanque_StartBomba = 7005;

        /// <remarks />
        public const uint TanqueType_BombaTanque_StopBomba = 7006;

        /// <remarks />
        public const uint Tanque1_BombaTanque_StartBomba = 7003;

        /// <remarks />
        public const uint Tanque1_BombaTanque_StopBomba = 7004;

        /// <remarks />
        public const uint Tanque2_BombaTanque_StartBomba = 7007;

        /// <remarks />
        public const uint Tanque2_BombaTanque_StopBomba = 7008;

        /// <remarks />
        public const uint Tanque3_BombaTanque_StartBomba = 7009;

        /// <remarks />
        public const uint Tanque3_BombaTanque_StopBomba = 7010;

        /// <remarks />
        public const uint Tanque4_BombaTanque_StartBomba = 7011;

        /// <remarks />
        public const uint Tanque4_BombaTanque_StopBomba = 7012;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint SensorType_BaseObject = 5002;

        /// <remarks />
        public const uint TanqueType_BombaTanque = 5008;

        /// <remarks />
        public const uint TanqueType_ControleVazao = 5009;

        /// <remarks />
        public const uint TanqueType_SensorTanque = 5003;

        /// <remarks />
        public const uint TanqueType_SensorTanque_BaseObject = 5004;

        /// <remarks />
        public const uint Tanque1 = 5007;

        /// <remarks />
        public const uint Tanque1_BombaTanque = 5010;

        /// <remarks />
        public const uint Tanque1_ControleVazao = 5011;

        /// <remarks />
        public const uint Tanque1_SensorTanque = 5012;

        /// <remarks />
        public const uint Tanque1_SensorTanque_BaseObject = 5013;

        /// <remarks />
        public const uint Tanque2 = 5016;

        /// <remarks />
        public const uint Tanque2_BombaTanque = 5017;

        /// <remarks />
        public const uint Tanque2_ControleVazao = 5018;

        /// <remarks />
        public const uint Tanque2_SensorTanque = 5019;

        /// <remarks />
        public const uint Tanque2_SensorTanque_BaseObject = 5020;

        /// <remarks />
        public const uint Tanque3 = 5023;

        /// <remarks />
        public const uint Tanque3_BombaTanque = 5024;

        /// <remarks />
        public const uint Tanque3_ControleVazao = 5025;

        /// <remarks />
        public const uint Tanque3_SensorTanque = 5026;

        /// <remarks />
        public const uint Tanque3_SensorTanque_BaseObject = 5027;

        /// <remarks />
        public const uint Tanque4 = 5030;

        /// <remarks />
        public const uint Tanque4_BombaTanque = 5031;

        /// <remarks />
        public const uint Tanque4_ControleVazao = 5032;

        /// <remarks />
        public const uint Tanque4_SensorTanque = 5033;

        /// <remarks />
        public const uint Tanque4_SensorTanque_BaseObject = 5034;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint BombaType = 1003;

        /// <remarks />
        public const uint ControleType = 1004;

        /// <remarks />
        public const uint SensorType = 1005;

        /// <remarks />
        public const uint TanqueType = 1006;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint BombaType_DL = 6001;

        /// <remarks />
        public const uint BombaType_EN = 6002;

        /// <remarks />
        public const uint BombaType_LG = 6003;

        /// <remarks />
        public const uint BombaType_ST = 6005;

        /// <remarks />
        public const uint BombaType_TRIP = 6006;

        /// <remarks />
        public const uint BombaType_VAL = 6019;

        /// <remarks />
        public const uint BombaType_YS = 6004;

        /// <remarks />
        public const uint ControleType_MV = 6024;

        /// <remarks />
        public const uint ControleType_PV = 6023;

        /// <remarks />
        public const uint ControleType_SP = 6022;

        /// <remarks />
        public const uint SensorType_Valor = 6014;

        /// <remarks />
        public const uint TanqueType_BombaTanque_DL = 6026;

        /// <remarks />
        public const uint TanqueType_BombaTanque_EN = 6027;

        /// <remarks />
        public const uint TanqueType_BombaTanque_LG = 6028;

        /// <remarks />
        public const uint TanqueType_BombaTanque_ST = 6029;

        /// <remarks />
        public const uint TanqueType_BombaTanque_TRIP = 6030;

        /// <remarks />
        public const uint TanqueType_BombaTanque_VAL = 6031;

        /// <remarks />
        public const uint TanqueType_BombaTanque_YS = 6032;

        /// <remarks />
        public const uint TanqueType_ControleVazao_MV = 6033;

        /// <remarks />
        public const uint TanqueType_ControleVazao_PV = 6034;

        /// <remarks />
        public const uint TanqueType_ControleVazao_SP = 6035;

        /// <remarks />
        public const uint TanqueType_SensorTanque_Valor = 6015;

        /// <remarks />
        public const uint Tanque1_BombaTanque_DL = 6016;

        /// <remarks />
        public const uint Tanque1_BombaTanque_EN = 6017;

        /// <remarks />
        public const uint Tanque1_BombaTanque_LG = 6018;

        /// <remarks />
        public const uint Tanque1_BombaTanque_ST = 6020;

        /// <remarks />
        public const uint Tanque1_BombaTanque_TRIP = 6021;

        /// <remarks />
        public const uint Tanque1_BombaTanque_VAL = 6025;

        /// <remarks />
        public const uint Tanque1_BombaTanque_YS = 6036;

        /// <remarks />
        public const uint Tanque1_ControleVazao_MV = 6037;

        /// <remarks />
        public const uint Tanque1_ControleVazao_PV = 6038;

        /// <remarks />
        public const uint Tanque1_ControleVazao_SP = 6039;

        /// <remarks />
        public const uint Tanque1_SensorTanque_Valor = 6040;

        /// <remarks />
        public const uint Tanque2_BombaTanque_DL = 6041;

        /// <remarks />
        public const uint Tanque2_BombaTanque_EN = 6042;

        /// <remarks />
        public const uint Tanque2_BombaTanque_LG = 6043;

        /// <remarks />
        public const uint Tanque2_BombaTanque_ST = 6044;

        /// <remarks />
        public const uint Tanque2_BombaTanque_TRIP = 6045;

        /// <remarks />
        public const uint Tanque2_BombaTanque_VAL = 6046;

        /// <remarks />
        public const uint Tanque2_BombaTanque_YS = 6047;

        /// <remarks />
        public const uint Tanque2_ControleVazao_MV = 6048;

        /// <remarks />
        public const uint Tanque2_ControleVazao_PV = 6049;

        /// <remarks />
        public const uint Tanque2_ControleVazao_SP = 6050;

        /// <remarks />
        public const uint Tanque2_SensorTanque_Valor = 6051;

        /// <remarks />
        public const uint Tanque3_BombaTanque_DL = 6052;

        /// <remarks />
        public const uint Tanque3_BombaTanque_EN = 6053;

        /// <remarks />
        public const uint Tanque3_BombaTanque_LG = 6054;

        /// <remarks />
        public const uint Tanque3_BombaTanque_ST = 6055;

        /// <remarks />
        public const uint Tanque3_BombaTanque_TRIP = 6056;

        /// <remarks />
        public const uint Tanque3_BombaTanque_VAL = 6057;

        /// <remarks />
        public const uint Tanque3_BombaTanque_YS = 6058;

        /// <remarks />
        public const uint Tanque3_ControleVazao_MV = 6059;

        /// <remarks />
        public const uint Tanque3_ControleVazao_PV = 6060;

        /// <remarks />
        public const uint Tanque3_ControleVazao_SP = 6061;

        /// <remarks />
        public const uint Tanque3_SensorTanque_Valor = 6062;

        /// <remarks />
        public const uint Tanque4_BombaTanque_DL = 6063;

        /// <remarks />
        public const uint Tanque4_BombaTanque_EN = 6064;

        /// <remarks />
        public const uint Tanque4_BombaTanque_LG = 6065;

        /// <remarks />
        public const uint Tanque4_BombaTanque_ST = 6066;

        /// <remarks />
        public const uint Tanque4_BombaTanque_TRIP = 6067;

        /// <remarks />
        public const uint Tanque4_BombaTanque_VAL = 6068;

        /// <remarks />
        public const uint Tanque4_BombaTanque_YS = 6069;

        /// <remarks />
        public const uint Tanque4_ControleVazao_MV = 6070;

        /// <remarks />
        public const uint Tanque4_ControleVazao_PV = 6071;

        /// <remarks />
        public const uint Tanque4_ControleVazao_SP = 6072;

        /// <remarks />
        public const uint Tanque4_SensorTanque_Valor = 6073;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BombaType_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.BombaType_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.BombaType_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.TanqueType_BombaTanque_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.TanqueType_BombaTanque_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque1_BombaTanque_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque1_BombaTanque_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque2_BombaTanque_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque2_BombaTanque_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque3_BombaTanque_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque3_BombaTanque_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_StartBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque4_BombaTanque_StartBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_StopBomba = new ExpandedNodeId(yourorganisation.org.Planta.Methods.Tanque4_BombaTanque_StopBomba, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId SensorType_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.SensorType_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.TanqueType_BombaTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_ControleVazao = new ExpandedNodeId(yourorganisation.org.Planta.Objects.TanqueType_ControleVazao, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_SensorTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.TanqueType_SensorTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_SensorTanque_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.TanqueType_SensorTanque_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1 = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque1, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque1_BombaTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_ControleVazao = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque1_ControleVazao, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_SensorTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque1_SensorTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_SensorTanque_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque1_SensorTanque_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2 = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque2, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque2_BombaTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_ControleVazao = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque2_ControleVazao, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_SensorTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque2_SensorTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_SensorTanque_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque2_SensorTanque_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3 = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque3, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque3_BombaTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_ControleVazao = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque3_ControleVazao, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_SensorTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque3_SensorTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_SensorTanque_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque3_SensorTanque_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4 = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque4, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque4_BombaTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_ControleVazao = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque4_ControleVazao, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_SensorTanque = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque4_SensorTanque, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_SensorTanque_BaseObject = new ExpandedNodeId(yourorganisation.org.Planta.Objects.Tanque4_SensorTanque_BaseObject, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BombaType = new ExpandedNodeId(yourorganisation.org.Planta.ObjectTypes.BombaType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ControleType = new ExpandedNodeId(yourorganisation.org.Planta.ObjectTypes.ControleType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(yourorganisation.org.Planta.ObjectTypes.SensorType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType = new ExpandedNodeId(yourorganisation.org.Planta.ObjectTypes.TanqueType, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BombaType_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId BombaType_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.BombaType_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ControleType_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.ControleType_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ControleType_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.ControleType_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ControleType_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.ControleType_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.SensorType_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_BombaTanque_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_BombaTanque_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_ControleVazao_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_ControleVazao_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_ControleVazao_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_ControleVazao_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_ControleVazao_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_ControleVazao_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId TanqueType_SensorTanque_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.TanqueType_SensorTanque_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_BombaTanque_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_BombaTanque_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_ControleVazao_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_ControleVazao_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_ControleVazao_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_ControleVazao_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_ControleVazao_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_ControleVazao_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1_SensorTanque_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque1_SensorTanque_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_BombaTanque_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_BombaTanque_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_ControleVazao_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_ControleVazao_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_ControleVazao_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_ControleVazao_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_ControleVazao_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_ControleVazao_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2_SensorTanque_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque2_SensorTanque_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_BombaTanque_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_BombaTanque_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_ControleVazao_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_ControleVazao_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_ControleVazao_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_ControleVazao_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_ControleVazao_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_ControleVazao_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3_SensorTanque_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque3_SensorTanque_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_DL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_DL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_EN = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_EN, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_LG = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_LG, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_ST = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_ST, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_TRIP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_TRIP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_VAL = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_VAL, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_BombaTanque_YS = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_BombaTanque_YS, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_ControleVazao_MV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_ControleVazao_MV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_ControleVazao_PV = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_ControleVazao_PV, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_ControleVazao_SP = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_ControleVazao_SP, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque4_SensorTanque_Valor = new ExpandedNodeId(yourorganisation.org.Planta.Variables.Tanque4_SensorTanque_Valor, yourorganisation.org.Planta.Namespaces.yourorganisationorgPlanta);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string BaseObject = "BaseObject";

        /// <remarks />
        public const string BombaTanque = "BombaTanque";

        /// <remarks />
        public const string BombaType = "BombaType";

        /// <remarks />
        public const string ControleType = "ControleType";

        /// <remarks />
        public const string ControleVazao = "ControleVazao";

        /// <remarks />
        public const string DL = "DL";

        /// <remarks />
        public const string EN = "EN";

        /// <remarks />
        public const string LG = "LG";

        /// <remarks />
        public const string MV = "MV";

        /// <remarks />
        public const string PV = "PV";

        /// <remarks />
        public const string SensorTanque = "SensorTanque";

        /// <remarks />
        public const string SensorType = "SensorType";

        /// <remarks />
        public const string SP = "SP";

        /// <remarks />
        public const string ST = "ST";

        /// <remarks />
        public const string StartBomba = "StartBomba";

        /// <remarks />
        public const string StopBomba = "StopBomba";

        /// <remarks />
        public const string Tanque1 = "Tanque1";

        /// <remarks />
        public const string Tanque2 = "Tanque2";

        /// <remarks />
        public const string Tanque3 = "Tanque3";

        /// <remarks />
        public const string Tanque4 = "Tanque4";

        /// <remarks />
        public const string TanqueType = "TanqueType";

        /// <remarks />
        public const string TRIP = "TRIP";

        /// <remarks />
        public const string VAL = "VAL";

        /// <remarks />
        public const string Valor = "Valor";

        /// <remarks />
        public const string YS = "YS";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the yourorganisationorgPlanta namespace (.NET code namespace is 'yourorganisation.org.Planta').
        /// </summary>
        public const string yourorganisationorgPlanta = "http://yourorganisation.org/Planta/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";
    }
    #endregion
}