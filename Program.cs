using System;

namespace Uc6_DeleteLastElement
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        internal Node head;

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} inserted into the link list", n.data);
                return true;
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} inserted into the link list", n.data);
                return true;
            }

        }
        public bool Pop(int index)
        {
            Node obj = head;
            if (index == 0)
            {
                head = head.next;
                return true;
            }
            Node t = head, pre = null;
            while (index > 0 && t != null)
            {
                index--;
                pre = t;
                t = t.next;
            }
            if (index == 0)
            {
                pre.next = t.next;
                return true;
            }
            throw new NullReferenceException("Index is not in range");
        }

        internal void Display()
        {
            Node t = head;
            if (t == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.data + " ");
                t = t.next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            Console.WriteLine("Last Element Deleted : ");
            list.Pop(2);

            list.Display();
        }
    }
}