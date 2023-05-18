using System;
using System.Collections.Generic;

public class MyStack
{

    //This is a terrible fucntion! It does 5 things and has a name that descirbes only one of them.
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        //Thing 1: Print Count
        Console.WriteLine("Number of items: {0}", aStack.Count);
        //Thing 2: Print top item
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());
        //Thing 3: Print if Item exisits
        bool found = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, found);
        //Thing 4: P0P Till Item
        if (found)
        {
            while (aStack.Pop() != search)
                continue;
        }
        //thing 5: Push new item
        aStack.Push(newItem);
        return aStack;
    }
}
