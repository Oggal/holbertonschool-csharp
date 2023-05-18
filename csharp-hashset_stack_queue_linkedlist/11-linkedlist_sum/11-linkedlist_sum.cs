using System;
using System.Collections.Generic;

public class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int i = 0;
        foreach (int j in myLList)
            i += j;
        return i;
    }
}