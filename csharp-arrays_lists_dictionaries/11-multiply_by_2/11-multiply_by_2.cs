using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach(string key in myDict.Keys)
            myDict[key] *= 2;
        return myDict;
    }

        
}