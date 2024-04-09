using System;

public class BinarySearchTree
{
    private Node? _root;

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Serialize(string list) 
    {
        // Write code to serialize the BST into an string
        // Hint: You can recursively call this function or recursively call another
    }

    public void Deserialize()
    {
        // Write code to deserialize a serialized BST
        // Hint: You can recursively call this function or recursively call another
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

        // Write the insert call to add the list string to the binary tree
    }
}

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(int data)
    {
        Data = data;
        Right = null;
        Left = null;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            if (Left == null)
            {
                Left = new Node(value);
            }
            else
            {
                Left.Insert(value);
            }
        }
        else if (value > Data)
        {
            if (Right == null)
            {
                Right = new Node(value);
            }
            else
            {
                Right.Insert(value);
            }
        }
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