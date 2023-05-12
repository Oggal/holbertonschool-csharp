using System;
using System.Collections.Generic;


public class LList{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int? j = (new List<int>(myLList))[index];
        if(j != null)
            myLList.Remove(j.Value);
    }
}
