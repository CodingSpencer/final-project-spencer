using System;

public class BinarySearchTree
{
    private Node? _root;

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Insert(int value)
    {
        Node newNode = new Node(value);
        // If empty, points to the root
        if (_root == null)
        {
            _root = newNode;
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
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {

        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        node = new Node(value);
        if (node is not null)
        {
            if (node.Data == value)
            {
                return true;
            }
            else
            {
                if (Contains(node.Left, value))
                {
                    return true;
                }

                if (Contains(node.Right, value))
                {
                    return true;
                }
            }
        }

    public void Display()
    {
        if (Left != null)
        {
            Left.Display();
        }
        Console.Write(Value + " ");
        if (Right != null)
        {
            Right.Display();
        }
    }
}
}
