public Node
{
public string Data;
public Node Next;

public Node(string data)
{
    Data = data;
    Next = null;
}
}

public LinkedList
{
private Node head;

public LinkedList()
{
    head = null;
}

public void Add(string data)
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
        Console.Writeline(nodeCurrent.Data + ", ");
        nodeCurrent = nodeCurrent.Next;
    }
}