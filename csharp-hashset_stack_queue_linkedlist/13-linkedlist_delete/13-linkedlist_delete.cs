using System;
using System.Collections.Generic;


public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
            return;
        int? j = (new List<int>(myLList))[index];
        if (j != null && j != 0)
            myLList.Remove(j.Value);
        if (j == 0)
            myLList.RemoveFirst();
    }
}
