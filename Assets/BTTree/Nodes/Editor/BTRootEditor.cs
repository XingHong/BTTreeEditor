using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;

namespace XNode.BTTree.Editor
{
    [CustomNodeEditor(typeof(BTRoot))]
    public class BTRootEditor : NodeEditor
    {
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            BTRoot node = target as BTRoot;
            BTTreeGraph graph = node.graph as BTTreeGraph;
            node.skillName = graph.name;
            if (graph.root == null)
            {
                graph.AddRoot(node);
            }
        }

        public override void OnCreate()
        {
            base.OnCreate();
            BTRoot node = target as BTRoot;
            BTTreeGraph graph = node.graph as BTTreeGraph;
            if (graph.root != null)
            {
                Debug.LogError("Only one root!");
            }
        }
    }
}
