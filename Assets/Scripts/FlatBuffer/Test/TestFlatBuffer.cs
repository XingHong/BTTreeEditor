using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using global::Google.FlatBuffers;
using Royal.Scenes.Game.Utils.FlatLevel;

public class TestFlatBuffer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var bytes = Resources.Load<TextAsset>("royalbin").bytes;
        ByteBuffer bb = new ByteBuffer(bytes);
        FTiledLevel test = FTiledLevel.GetRootAsFTiledLevel(bb);
        var obj = test.UnPack();
        string str = JsonUtility.ToJson(obj);
        Debug.Log($"test ok Name:{str}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
