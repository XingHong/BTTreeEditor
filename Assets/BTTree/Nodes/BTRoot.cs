using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using XNode.BTTree.Framework;
using SimpleJSON;

namespace XNode.BTTree
{ 
	public class BTRoot : Node {

		[Space(5)]
		public string SkillName;
		[Output] 
		public Node Child;

		// Use this for initialization
		protected override void Init() {
			base.Init();
			SkillName = graph.name;
		}

		protected virtual void OnInputChanged()
		{
			var np = GetPort("Child");
			var connections = np.GetConnections();
            if (connections.Count > 1)
            {
                connections[0].Disconnect(np);
            }
        }

		public override void OnCreateConnection(NodePort from, NodePort to)
		{
			OnInputChanged();
		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port) {
			return null; // Replace this
		}

		public JSONObject GetRootData()
		{
			var rootData = new JSONObject();
			rootData[nameof(SkillName)] = SkillName;
			rootData["Root"] = "Root";
			var np = GetPort("Child");
			var connections = np.GetConnections();
			if (connections.Count > 0)
			{ 
				var node = connections[0].node as BaseBTNode;
				rootData["Child"] = node.GetNodeData();
			}
			return rootData;
		}
	}
}