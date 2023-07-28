using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Type custDataType = PropertyBuilderUtils.BuildBTTreeNodeType();

        PropertyInfo[] custDataPropInfo = custDataType.GetProperties();
        
        foreach (PropertyInfo pInfo in custDataPropInfo)
        {
            Debug.LogFormat("Property '{0}' created!", pInfo.ToString());
        }

        FieldInfo[] custDataFieldInfo = custDataType.GetFields();
        foreach (FieldInfo fInfo in custDataFieldInfo)
        {
            Debug.LogFormat("Field '{0}' created!", fInfo.ToString());
        }

        Debug.LogFormat("---");
        // Note that when invoking a property, you need to use the proper BindingFlags -
        // BindingFlags.SetProperty when you invoke the "set" behavior, and
        // BindingFlags.GetProperty when you invoke the "get" behavior. Also note that
        // we invoke them based on the name we gave the property, as expected, and not
        // the name of the methods we bound to the specific property behaviors.

        //object custData = Activator.CreateInstance(custDataType);
        //custDataType.InvokeMember("CustomerName", BindingFlags.SetProperty,
        //                              null, custData, new object[] { "Joe User" });

        //Debug.LogFormat("The customerName field of instance custData has been set to '{0}'.",
        //                   custDataType.InvokeMember("CustomerName", BindingFlags.GetProperty,
        //                                              null, custData, new object[] { }));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
