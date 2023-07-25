using System;
using System.Collections.Generic;

namespace XNode.BTTree.Framework
{
    [System.Serializable]
    public class NodeData
    {
        public string TypeName;
        public List<object> children = new List<object>();
    }
}
