using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> res = new List<int>(list1);
        foreach(int i in list2)
        {
            if(!res.Contains(i))
                res.Add(i);
            else
                res.Remove(i);
        }
        return res;
    }
}
