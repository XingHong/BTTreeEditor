using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace XNode.BTTree
{ 
	public class BTRoot : Node {

		[Space(5)]
		public string skillName;
		[Output] 
		public Node Child;
		// Use this for initialization
		protected override void Init() {
			base.Init();
			skillName = "New Skill";
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
	}
}