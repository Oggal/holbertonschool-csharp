using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int i = myLList.First.Value;
        myLList.RemoveFirst();
        return i;
    }
}
