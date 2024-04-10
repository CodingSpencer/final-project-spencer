// See https://aka.ms/new-console-template for more information
using System;

public class BinarySearchTree
{
    private Node _root;

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Insert(int value)
    {
        if (_root == null)
        {
            _root = new Node(value);
        }
        else
        {
            _root.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        return _root != null && _root.Contains(value);
    }

    public void Display()
    {
        if (_root != null)
        {
            _root.Display();
        }
    }

    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(1);
        bst.Insert(4);
        bst.Insert(8);

        Console.WriteLine("Does the tree contain the value 3? " + bst.Contains(3));

        bst.Display();
    }
}

public class Node 
{
    public int Data { get; set; }
    public Node Right { get; set; }
    public Node Left { get; set; }

    public Node(int data)
    {
        this.Data = data;
        this.Right = null;
        this.Left = null;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            // Duplicates not allowed
            return;
        }
        else if (value < Data)
        {
            // Insert item to the left
            if (Left == null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert item to the right
            if (Right == null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value);
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value);
        }
        return false;
    }

    public void Display()
    {
        if (Left != null)
        {
            Left.Display();
        }
        Console.Write(Data + " ");
        if (Right != null)
        {
            Right.Display();
        }
    }
}