using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] res = new int[size];
        for(int i = 0; i < size; i++)
            Console.Write("{0}{1}",(res[i] = i), " ");
        Console.WriteLine();
        return res;
    }
} 