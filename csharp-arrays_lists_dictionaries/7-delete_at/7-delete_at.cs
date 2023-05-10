using System;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        List<int> res = new List<int>();
        for(int i = 0; i < myList.Length; i++)
        {
            if( i == index)
                continue;
            res.Add(myList[i]);
        }
    }

}