using System;
using System.Collections.Generic;


public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> res = new HashSet<int>();
        foreach (int i in list1)
        {
            if (list2.Contains(i))
                res.Add(i);
        }
        return new List<int>(res);
    }
}