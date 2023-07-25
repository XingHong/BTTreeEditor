using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace XNode.BTTree
{ 
	[CreateAssetMenu(fileName = "New BTTree Graph")]
	public class BTTreeGraph : NodeGraph {
		public BTRoot root;

		public void AddRoot(BTRoot root)
		{
			this.root = root;
		}
	}
}
