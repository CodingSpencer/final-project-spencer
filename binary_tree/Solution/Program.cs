// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Collections.Generic;

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

public class BinarySearchTree
{
    private Node? _root;

    public BinarySearchTree()
    {
        _root = null;
    }

    public string Serialize() 
    {
        StringBuilder items = new StringBuilder();
        Serialize(_root, items);
        return items.ToString();
    }

    private void Serialize(Node? node, StringBuilder items) 
    {
        // Write code to serialize the BST into a string
        if (node == null)
        {
            return;
        }

        items.Append(node.Data + " ");
        Serialize(node.Left, items);
        Serialize(node.Right, items);
    }

    public static Node Deserialize(string serializedTree)
    {
        // Write code to deserialize a BST string
        if (string.IsNullOrEmpty(serializedTree))
        {
            return null;
        }

        string[] values = serializedTree.Split(' ');
        Queue<string> queue = new Queue<string>(values);
        return DeserializeQueue(queue);
    }

    private static Node? DeserializeQueue(Queue<string> queue)
    {
        if (queue.Count == 0)
        {
            return null;
        }

        string item = queue.Dequeue();
        if (string.IsNullOrEmpty(item) || item == "null")
        {
            return null;
        }

        int value = int.Parse(item);
        Node node = new Node(value);
        node.Left = DeserializeQueue(queue);
        node.Right = DeserializeQueue(queue);
        return node;
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

        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(1);
        bst.Insert(4);
        bst.Insert(8);

        // Use the serialize operation to get a sting
        string serializedTree = bst.Serialize();
        Console.WriteLine("Serialized tree: " + serializedTree);

        // Create another binary search tree object and use deserialize method to recreate the original tree
        Node? deserializedRoot = BinarySearchTree.Deserialize(serializedTree);
        BinarySearchTree deserializedBST = new BinarySearchTree();
        deserializedBST._root = deserializedRoot;
        Console.Write("Deserialized BST: ");
        deserializedBST.Display();
    }
}