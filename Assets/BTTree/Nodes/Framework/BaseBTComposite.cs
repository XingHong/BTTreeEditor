using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace XNode.BTTree.Framework
{
	[NodeTint(70, 70, 100)]
	public class BaseBTComposites : BaseBTNode
	{
		[Output]
		public Node Children;
		// Use this for initialization
		protected override void Init() {
			base.Init();
		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port) {
			return null; // Replace this
		}

        public override JSONObject GetNodeData()
        {
			Data = base.GetNodeData();
			var np = GetPort("Children");
			var connections = np.GetConnections();
			connections.Sort((NodePort x, NodePort y) => { return x.node.position.y > y.node.position.y ? 1 : -1; });

			JSONArray array = new JSONArray();

			for (int i = 0; i < connections.Count; ++i)
			{
				var p = connections[i];
				BaseBTNode bn = p.node as BaseBTNode;
				array[i] = bn.GetNodeData();
			}
			Data["Children"] = array;
			return Data;

		}
    }
}