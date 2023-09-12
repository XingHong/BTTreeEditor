using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using FlexBuffers;
using UnityEngine.Profiling;
using System.IO;


public class JsonVsFlexBuffers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Profiler.BeginSample("simple json import");
        //var txt = Resources.Load<TextAsset>("dataJson").text;
        //JSON.Parse(txt);
        //Profiler.EndSample();

        //Profiler.BeginSample("FlexBuffer import");
        //var bytes = Resources.Load<TextAsset>("data").bytes;
        //FlxValue val = FlxValue.FromBytes(bytes);
        //Profiler.EndSample();

        var txt = Resources.Load<TextAsset>("fbjsondata").text;
        Profiler.BeginSample("simple json import");
        JSON.Parse(txt);
        Profiler.EndSample();

        Profiler.BeginSample("FlexBuffer json import");
        var bytes = JsonToFlexBufferConverter.Convert(txt);
        FlxValue val = FlxValue.FromBytes(bytes);
        Profiler.EndSample();
        //var map = val["at"].AsMap;
        //map.KeyIndex()
        //var typ = map["a"].ValueType;

        //JSONArray arr = new JSONArray();
        //for (long i = 0; i < 100000; ++i)
        //{
        //    arr[(int)i] = i;
        //}

        //Profiler.BeginSample("simple json read");
        //List<long> list = new List<long>();
        //for (int i = 0; i < 100000; ++i)
        //{
        //    list.Add(arr[i]);
        //}
        //Profiler.EndSample();

        //var buffer = JsonToFlexBufferConverter.Convert(arr.ToString());
        //FlxValue val = FlxValue.FromBytes(buffer);
        //FlxVector vec = val.AsVector;

        //Profiler.BeginSample("FlexBuffer read");
        //List<long> list2 = new List<long>();
        //for (int i = 0; i < 100000; ++i)
        //{
        //    list2.Add(vec[i].AsLong);
        //}
        //Profiler.EndSample();
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0,0, 50, 30), "gen"))
        {
            JSONArray arr = new JSONArray();
            for (long i = 0; i < 100000; ++i)
            {
                arr[(int)i] = i;
            }

            string path = Path.Combine(Application.dataPath, "Resources/data.json");
            File.WriteAllText(path, arr.ToString());

            var buffer = JsonToFlexBufferConverter.Convert(arr.ToString());
            string bytesPath = Path.Combine(Application.dataPath, "Resources/data.txt");
            File.WriteAllBytes(bytesPath, buffer);
        }
    }
}
