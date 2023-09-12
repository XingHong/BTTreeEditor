using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Google.FlatBuffers;
using FBTest;
using UnityEngine.Profiling;

public class JsonVsFlatBuffers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Profiler.BeginSample("simple json import");
        var txt = Resources.Load<TextAsset>("fbjsondata").text;
        var obj = JSON.Parse(txt);
        Profiler.EndSample();

        Profiler.BeginSample("simple json read");
        List<int> list = new List<int>();
        for (int i = 0; i < 100000; ++i)
        {
            list.Add(obj["list"][i]);
        }
        Profiler.EndSample();

        Profiler.BeginSample("FlatBuffer import");
        var bytes = Resources.Load<TextAsset>("fbbindata").bytes;
        var buf = new ByteBuffer(bytes);
        var monList = MonsterList.GetRootAsMonsterList(buf);
        Profiler.EndSample();

        Profiler.BeginSample("FlatBuffer read");
        List<int> list2 = new List<int>();
        for (int i = 0; i < 100000; ++i)
        {
            var item = monList.List(i).Value;
            list2.Add(item.Id);
        }
        Profiler.EndSample();
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 50, 30), "gen"))
        {
            JSONObject root = new JSONObject();
            JSONArray arr = new JSONArray();
            for (int i = 0; i < 100000; ++i)
            {
                JSONObject obj = new JSONObject();
                obj["id"] = 100000;
                arr[i] = obj;
            }
            root["list"] = arr;

            string path = Path.Combine(Application.dataPath, "Resources/fbjsondata.json");
            File.WriteAllText(path, root.ToString());
        }
    }
}
