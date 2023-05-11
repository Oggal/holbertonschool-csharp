using System;
using System.Collections.Generic;


public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> res = new HashSet<int>();
        foreach(int i in list1)
        {
            foreach(int j in list2)
            {
                if (i == j){
                    res.Add(i);
                    break;
                }
            }
        }
        return new List<int>(res);
    }
}