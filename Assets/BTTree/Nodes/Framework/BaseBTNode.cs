using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using SimpleJSON;

namespace XNode.BTTree.Framework
{ 
	public class BaseBTNode : Node, IDataExport
	{

		[Input]
		public Node Parent;

		//node info
		protected string TypeName;
        protected JSONObject Data;

		// Use this for initialization
		protected override void Init() {
			base.Init();
			TypeName = GetType().Name;
		}

		protected virtual void OnInputChanged()
		{
			var np = GetPort("Parent");
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

        public virtual JSONObject GetNodeData()
        {
			Data = new JSONObject();
			Data[nameof(TypeName)] = TypeName;
			return Data;
        }
    }
}