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
            node.SkillName = graph.name;
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
            var nodes = graph.nodes;
            int cnt = 0;
            foreach (var n in nodes)
            {
                if (n is BTRoot)
                    ++cnt;
            }
            if (cnt > 1)
            {
                Debug.LogError("Only one root!");
            }
        }
    }
}
