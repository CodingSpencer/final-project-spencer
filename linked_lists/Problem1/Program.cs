using System;

public class ListNode {
    public int value;
    public ListNode next;
    public ListNode(int val = 0, ListNode.next = null){
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    public ListNode = head;

    public void AddFirst(int value){
        ListNode  newNode = new ListNode(value);
        newNode.next = head;
        head = newNode;
    }

    public void RemoveFirst(){
        if (head == null){
            Console.Writeline('The list is empty');
            return ;
        }
        int removedValue = head.val;
        head = head.next;
        return removedValue;
    }

    public void Add(int value){
        // Add code to add a node at the end of the linked list
    }

    public void Remove(int value) {
        // Add code to remove a node from any place in the list
    }

    public void RemoveDuplicates(){
        // Add your code here to find and remove any duplicates
    }

    public void PrintList(){
        ListNode current = head;
        while (current != null){
            Console.Writeline(current.val + ' ');
            current = current.next;
        }
        Console.Writeline();
    }
}

class Program {
    static void Main(string[ ] args) {
        LinkedList list = new LinkedList();


    }
}