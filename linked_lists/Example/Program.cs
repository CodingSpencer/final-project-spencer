// See https://aka.ms/new-console-template for more information
using System;

public class Node
{
    public string Data;
    public Node Next;

    public Node(string data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void Append(string data) // Changed method name from Add to Append
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node lastNode = head;
        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }

        lastNode.Next = newNode;
    }

    public void PrintList()
    {
        Node nodeCurrent = head;
        while (nodeCurrent != null)
        {
            string address = nodeCurrent.GetHashCode().ToString("X");
            Console.WriteLine(nodeCurrent.Data + "|" + address + ", "); // Corrected WriteLine casing
            nodeCurrent = nodeCurrent.Next;
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        LinkedList strings = new LinkedList(); // Removed generic type argument

        strings.Append("First");
        strings.Append("Second");
        strings.Append("Third");
        strings.Append("Fourth");

        Console.Write("Linked List: ");
        strings.PrintList();
    }
}
