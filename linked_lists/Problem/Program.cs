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
        ListNode newNode = new ListNode(value);
        if (head == null){
            head = newNode;
            return;
        }

        ListNode current = head;
        while (current.next != null){
            current = current.next;
        }
        current.next = newNode;
    }

    public void Remove(int value) {
        if (head = null){
            return;
        }

        if  (head.val == value){
            head = head.next;
            return;
        }

        ListNode current = head;
        ListNode prev = null;
        while (current != null && current.val != value){
            prev = current;
            current = current.next;
        }

        if (current != null){
            prev.next = current.next;
        }
    }

    public void RemoveDuplicates(){
        Hashset<int> seen = new Hashset<int> ();
        ListNode current = head;
        ListNode prev = null;
        while (current != null){
            if (!seen.contains(current.val)){
                seen.add(current.val);
                prev = current;
                current = current.next;
            } else{
                prev.next = current.next;
                current = current.next
            }
        }
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