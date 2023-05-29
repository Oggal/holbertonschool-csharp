using System;

/// <summary> Queue class </summary>
public class Queue<T>
{

    class Node
    {
        T value = null;
        T next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    /// <summary> Returns the Queue's type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    public T Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
        return node.value;
    }    

}


