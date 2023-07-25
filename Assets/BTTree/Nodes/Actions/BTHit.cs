using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using XNode.BTTree.Framework;

namespace XNode.BTTree.Actions
{ 
	[NodeWidth(120)]
	public class BTHit : BaseBTLeaf
	{
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