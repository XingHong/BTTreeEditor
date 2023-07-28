using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;
using System;
using XNode.BTTree.Framework;

public class PropertyBuilderUtils
{
    public static Type BuildDynamicTypeWithProperties()
    {
        AppDomain myDomain = Thread.GetDomain();
        AssemblyName myAsmName = new AssemblyName();
        myAsmName.Name = "MyDynamicAssembly";

        // To generate a persistable assembly, specify AssemblyBuilderAccess.RunAndSave.
        AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
                                                        AssemblyBuilderAccess.RunAndSave);
        // Generate a persistable single-module assembly.
        ModuleBuilder myModBuilder =
            myAsmBuilder.DefineDynamicModule(myAsmName.Name, myAsmName.Name + ".dll");

        TypeBuilder myTypeBuilder = myModBuilder.DefineType("CustomerData",
                                                        TypeAttributes.Public);
        myTypeBuilder.SetParent(typeof(BTTest));

        FieldBuilder customerNameBldr = myTypeBuilder.DefineField("customerName",
                                                        typeof(string),
                                                        FieldAttributes.Private);

        // The last argument of DefineProperty is null, because the
        // property has no parameters. (If you don't specify null, you must
        // specify an array of Type objects. For a parameterless property,
        // use an array with no elements: new Type[] {})
        PropertyBuilder custNamePropBldr = myTypeBuilder.DefineProperty("CustomerName",
                                                         PropertyAttributes.HasDefault,
                                                         typeof(string),
                                                         null);

        // The property set and property get methods require a special
        // set of attributes.
        MethodAttributes getSetAttr =
            MethodAttributes.Public | MethodAttributes.SpecialName |
                MethodAttributes.HideBySig;

        // Define the "get" accessor method for CustomerName.
        MethodBuilder custNameGetPropMthdBldr =
            myTypeBuilder.DefineMethod("get_CustomerName",
                                       getSetAttr,
                                       typeof(string),
                                       Type.EmptyTypes);

        ILGenerator custNameGetIL = custNameGetPropMthdBldr.GetILGenerator();

        custNameGetIL.Emit(OpCodes.Ldarg_0);
        custNameGetIL.Emit(OpCodes.Ldfld, customerNameBldr);
        custNameGetIL.Emit(OpCodes.Ret);

        // Define the "set" accessor method for CustomerName.
        MethodBuilder custNameSetPropMthdBldr =
            myTypeBuilder.DefineMethod("set_CustomerName",
                                       getSetAttr,
                                       null,
                                       new Type[] { typeof(string) });

        ILGenerator custNameSetIL = custNameSetPropMthdBldr.GetILGenerator();

        custNameSetIL.Emit(OpCodes.Ldarg_0);
        custNameSetIL.Emit(OpCodes.Ldarg_1);
        custNameSetIL.Emit(OpCodes.Stfld, customerNameBldr);
        custNameSetIL.Emit(OpCodes.Ret);

        // Last, we must map the two methods created above to our PropertyBuilder to
        // their corresponding behaviors, "get" and "set" respectively.
        custNamePropBldr.SetGetMethod(custNameGetPropMthdBldr);
        custNamePropBldr.SetSetMethod(custNameSetPropMthdBldr);

        Type retval = myTypeBuilder.CreateType();

        // Save the assembly so it can be examined with Ildasm.exe,
        // or referenced by a test program.
        myAsmBuilder.Save(myAsmName.Name + ".dll");
        return retval;
    }

    public static Type BuildBTTreeNodeType()
    {
        AppDomain myDomain = Thread.GetDomain();
        AssemblyName myAsmName = new AssemblyName();
        myAsmName.Name = "BTTreeNodeAssembly";

        // To generate a persistable assembly, specify AssemblyBuilderAccess.RunAndSave.
        AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
                                                        AssemblyBuilderAccess.RunAndSave);
        // Generate a persistable single-module assembly.
        ModuleBuilder myModBuilder =
            myAsmBuilder.DefineDynamicModule(myAsmName.Name, myAsmName.Name + ".dll");

        TypeBuilder myTypeBuilder = myModBuilder.DefineType("XNode.BTTree.Actions.BTTestAction",
                                                        TypeAttributes.Public);
        myTypeBuilder.SetParent(typeof(BaseBTLeaf));

        Type targetType = typeof(BTTest);
        
        foreach (var field in targetType.GetFields())
        { 
            FieldBuilder customerNameBldr = myTypeBuilder.DefineField(field.Name,
                                                            field.FieldType,
                                                            FieldAttributes.Public);
        }

        

        Type retval = myTypeBuilder.CreateType();

        // Save the assembly so it can be examined with Ildasm.exe,
        // or referenced by a test program.
        myAsmBuilder.Save(myAsmName.Name + ".dll");
        return retval;
    }
}
