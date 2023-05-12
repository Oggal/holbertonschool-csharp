using System;

public class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int res = -1;
        foreach(int i in myLList)
        {
            res++;
            if(i == value)
                return res;
        }
        return -1;
    }
}
