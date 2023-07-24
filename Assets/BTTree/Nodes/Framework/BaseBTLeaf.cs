using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace XNode.BTTree.Framework
{
	[NodeTint(100, 70, 70)]
	public class BaseBTLeaf : BaseBTNode
	{
		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null; // Replace this
		}
	}
}