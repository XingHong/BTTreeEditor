using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;
using XNode.BTTree;
using System;

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
			try
			{
				if (type.FullName.Contains("BTTestAction"))
					return base.GetNodeMenuName(type);
				if (type.Namespace.Contains("XNode.BTTree") && !string.IsNullOrEmpty(type.Namespace) && !type.Namespace.Contains("XNode.BTTree.Framework"))
				{
					var tmp = base.GetNodeMenuName(type);
					return base.GetNodeMenuName(type).Replace("X Node/BT Tree/", "");
				}
			}
			catch (Exception ex)
			{
				return null;
			}

			return null;
		}
	}
}

