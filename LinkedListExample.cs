using System;
class Node
{
    public int data;
    public Node next;
}
class LinkedListExample
{
    Node head = null;
    public void Add(int value)
    {
        Node newNode = new Node();
        newNode.data = value;
        newNode.next = null;
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
    public void Find(int value)
    {
        Node temp = head;
        while ( temp != null)
        {
            if ( temp.data == value)
            {
                Console.WriteLine("value found");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("value not found");
    }   
    public void Remove(int value)
    {
        Node temp = head;
        Node prev = null;
        while (temp != null)
        {
            if(temp.data == value)
            {
                if(prev == null)
                {
                    head = temp.next;
                }
                else
                {
                    prev.next = temp.next;
                }
                Console.WriteLine("Node removed");
                return;
            }
            prev = temp;
            temp = temp.next;
        }
        Console.WriteLine("value not found");
    }
}
class Program
{
    static void Main()
    {
        LinkedListExample list = new LinkedListExample();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("Linked List:");
        list.Display();
        list.Find(20);
        list.Remove(20);
        Console.WriteLine("After removing:");
        list.Display();
    }
}