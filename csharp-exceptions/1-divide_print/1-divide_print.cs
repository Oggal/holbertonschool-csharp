using System;

public class Int
{
    public static void divide(int a, int b)
    {
        int res = 0;
        try
        {
            res = a / b;
        }
        catch(Exception e)
        {
            e = null;
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, res);
        }
    }
}
