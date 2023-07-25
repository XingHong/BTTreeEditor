using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using SimpleJSON;
using System.IO;
using UnityEditor;
using System;

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
			string path = Path.Combine(Application.dataPath, $"BTTreeJson/{this.root.SkillName}.json");
			StreamWriter sw = new StreamWriter(path);
			string jsonStr = finalData.ToString() + Environment.NewLine;
			sw.Write(jsonStr);
			sw.Close();
			AssetDatabase.Refresh();
		}
    }
}
