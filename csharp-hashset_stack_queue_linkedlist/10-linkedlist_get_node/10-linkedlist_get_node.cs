using System;
using System.Collections.Generic;


public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if(n >= myLList.Count || n < 0)
            return 0;
        return (new List<int>(myLList))[n];
    }
}
