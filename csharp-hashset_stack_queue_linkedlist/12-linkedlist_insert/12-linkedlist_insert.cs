using System;
using System.Collections.Generic;


public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> last = null, node = myLList.First;
        
        while(node != null)
        {
            if( n < node.Value && (last == null || n > last.Value ))
                return myLList.AddBefore(node,n);
            last = node;
            node = node.Next;
        }
        return myLList.AddLast(n);
    }
}
