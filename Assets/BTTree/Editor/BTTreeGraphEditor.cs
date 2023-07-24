using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;
using XNode.BTTree;

namespace XNode.BTTree
{ 
	[CustomNodeGraphEditor(typeof(BTTreeGraph))]
	public class BTTreeGraphEditor : NodeGraphEditor
	{

		/// <summary> 
		/// Overriding GetNodeMenuName lets you control if and how nodes are categorized.
		/// In this example we are sorting out all node types that are not in the XNode.Examples namespace.
		/// </summary>
		public override string GetNodeMenuName(System.Type type)
		{
			if (type.Namespace.Contains("XNode.BTTree") && !type.Namespace.Contains("XNode.BTTree.Framework"))
			{
				var tmp = base.GetNodeMenuName(type);
				return base.GetNodeMenuName(type).Replace("X Node/BT Tree/", "");
			}
			else return null;
		}
	}
}

