using System;

public class HexHex
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 100; i++)
        {
            Console.Write("{0}{1}", i.ToString("00"), i !=99? ", ":"");
        }
    }
}