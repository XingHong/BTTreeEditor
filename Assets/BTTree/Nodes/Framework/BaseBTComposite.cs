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
}
}