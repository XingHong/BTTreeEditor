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

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port) {
			return null; // Replace this
		}
	}
}