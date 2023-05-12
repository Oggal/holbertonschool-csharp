using System;
using System.Collections.Generic;


public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> res = new LinkedList<int>();

        for(int i = 0; i < size; i++)
            {
                res.AddLast(i);
                Console.WriteLine(i);
            }

        return res;
    }
}
