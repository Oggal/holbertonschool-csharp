using System;
using System.Collections.Generic;


public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> last = null;
        foreach(LinkedListNode<int> node in myLList)
        {
            if(last != null)
            {
                if(n>last.Value)
                    return myLList.AddBefore(last,n);
            }else{
                if( n < node.Value)
                    return myLList.AddBefore(node, n);
            }
        }
        return myLList.AddLast(n);
    }
}
