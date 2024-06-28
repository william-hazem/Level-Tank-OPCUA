using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace TankClientUI
{
    public class CustomTreeNode : TreeNode
    {
        public string NodeType { get; set; }
        public string NodeValue { get; set; }
        public string NodeName { get; set; }
        public BuiltInType BuiltinType { get; set; }
        public CustomTreeNode(string name, string type, string value, BuiltInType builtinType) : base()
        {
            this.NodeName = name;
            this.NodeType = type;
            this.NodeValue = value;
            this.BuiltinType = builtinType;
            UpdateText();
        }

        public void UpdateText()
        {
            if (this.BuiltinType > BuiltInType.Null)
                this.Text = $"{this.NodeName} ({this.NodeType}): {this.NodeValue}";
            else
                this.Text = $"{this.NodeName} ({this.NodeType})";
        }
    }
}
