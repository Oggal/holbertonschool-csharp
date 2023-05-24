using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Obj class </summary>
public static class Obj
{
    ///<summary> Checks if object is an subclass of basetype </summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();

        List<PropertyInfo> props = new List<PropertyInfo>(t.GetProperties());
        List<MethodInfo> methods = new List<MethodInfo>(t.GetMethods());

        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo prop in props)
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
