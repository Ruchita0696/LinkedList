using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine($"{node.data} is Inserted in Linked List\n");
        }
        public void Insert_front(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        public void Insert_Last(int data)
        {
            Node newNode = new Node(data);
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }
        public void Display()
        {
            int i = 1;
            Node temp = head;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");

            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                i++;
            }
        }
        
    }
}
