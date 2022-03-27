using System;

namespace Uc2_LinkedListSequence
{
    public class Node
    {
        public int data;
        public Node next; //val is null

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkList
    {
        internal Node head; //val null

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
            LinkList list = new LinkList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
        }
    }
}
