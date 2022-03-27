using System;

namespace Uc5_DeleteFirstElement
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

        public bool Delete(int input)
        {
            if (head == null)
            {
                return false;
            }
            if (head.next == null)
            {
                head = null;
            }

            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
                {
                    pre.next = t.next;
                    Console.WriteLine("{0} data has been deleted from linked List", input);
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
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
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Delete(56);
            list.Display();
        }
    }
}
