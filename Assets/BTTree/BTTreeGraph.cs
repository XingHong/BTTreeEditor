using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using SimpleJSON;

namespace XNode.BTTree
{ 
	[CreateAssetMenu(fileName = "New BTTree Graph")]
	public class BTTreeGraph : NodeGraph {
		public BTRoot root;

		public void AddRoot(BTRoot root)
		{
			this.root = root;
		}

        public override void ExportData()
        {
			var finalData = this.root.GetRootData();
			//JSON.
			Debug.Log(finalData);
		}
    }
}
