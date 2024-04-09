using System;

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
        Serialize(_root, items)
        return items.ToString();
    }

    private void Serialize(Node node, StringBuilder items) 
    {
        // Write code to serialize the BST into an string
        if (node == null){

        }
        else
        {
            sb.Append(node.value + " ");
            Serialize(node.left, sb);
            Serialize(node.right, sb);
        }
    }

    public static Node Deserialize()
    {
        // Write code to deserialize a BST string
        // Hint: You can recursively call this function or recursively call another
        string[]  values = list.Split(' ');
        Queue<string> queue = new Queue<string> (values);
        return DeserializeQueue(queue);
    }

    private static Node DeserializeQueue(Queue<string> queue)
    {
        string item = queue.Dequeue();
        int value = int.Parse(item);
        Node node = new Node(item);
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
        Console.WriteLine("Deserialized BST:");
        deserializedBST.Display();
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