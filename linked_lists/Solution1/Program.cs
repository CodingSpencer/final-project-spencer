using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null){
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    public ListNode head; // Fixed the assignment here, removed '='

    public void AddFirst(int value){
        ListNode newNode = new ListNode(value);
        newNode.next = head;
        head = newNode;
    }

    public int RemoveFirst(){ // Changed return type to int to match the removed value
        if (head == null){
            Console.WriteLine("The list is empty"); // Corrected WriteLine casing
            return -1; // Return a default value indicating failure
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
        if (head == null){ // Corrected comparison operator
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
        HashSet<int> seen = new HashSet<int> (); // Corrected HashSet casing
        ListNode current = head;
        ListNode prev = null;
        while (current != null){
            if (!seen.Contains(current.val)){
                seen.Add(current.val);
                prev = current;
                current = current.next;
            } else{
                prev.next = current.next;
                current = current.next; // Added missing semicolon
            }
        }
    }

    public void PrintList(){
        ListNode current = head;
        while (current != null){
            Console.WriteLine(current.val + " "); // Corrected WriteLine casing, added space for formatting
            current = current.next;
        }
        Console.WriteLine(); // Corrected WriteLine casing
    }
}

class Program {
    static void Main(string[] args) { // Corrected array syntax
        LinkedList list = new LinkedList();
        
        list.AddFirst(10);
        list.AddFirst(20);
        list.Add(30);
        list.PrintList();

        list.RemoveDuplicates();
        list.PrintList();
    }
}
