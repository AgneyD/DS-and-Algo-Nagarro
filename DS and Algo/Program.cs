using System;

namespace Linekd_List
{
    class Program
    {
        public class Node
        {
            public Node Next;
            public object Value;
        }

        public class LinkedList
        {
            private Node head;
            private Node current;
            public int Count;

            public LinkedList()
            {
                head = new Node();
                current = head;
            }

            //Insert
            public void AddAtLast(object data)
            {
                Node newNode = new Node();
                newNode.Value = data;
                current.Next = newNode;
                current = newNode;
                Count++;
            }
            public void AddAtStart(object data)
            {
                Node newNode = new Node() { Value = data };
                newNode.Next = head.Next;
                head.Next = newNode;
                Count++;
            }

            public void AddAtPosition(int newElement, int position)
            {

                Node newNode = new Node();
                newNode.Value = newElement;
                newNode.Next = null;

                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.Next;
                        }
                    }

                    if (temp != null)
                    {
                        newNode.Next = temp.Next;
                        temp.Next = newNode;
                    }
                    else
                    {
                        Console.Write("\nThe previous node is null.");
                    }
                }
            }

            //Delete
            public void RemoveFromStart()
            {
                if (Count > 0)
                {
                    head.Next = head.Next.Next;
                    Count--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }

            public void RemoveAtLast()
            {
                if (this.head != null)
                {

                    if (this.head.Next == null)
                    {
                        this.head = null;
                    }
                    else
                    {
                        Node temp = new Node();
                        temp = this.head;
                        while (temp.Next.Next != null)
                            temp = temp.Next;

                        Node lastNode = temp.Next;
                        temp.Next = null;
                        lastNode = null;
                    }
                }
            }

            public void RemoveAtPosition(int position)
            {

                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1 && head != null)
                {
                    Node nodeToDelete = head;
                    head = head.Next;
                    nodeToDelete = null;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.Next;
                        }
                    }

                    if (temp != null && temp.Next != null)
                    {
                        Node nodeToDelete = temp.Next;
                        temp.Next = temp.Next.Next;
                        nodeToDelete = null;
                    }
                    else
                    {
                        Console.Write("\nThe node is already null.");
                    }
                }
            }

            //Middle Element
            public void PrintMiddle()
            {
                Node slow_ptr = head;
                Node fast_ptr = head;

                if (head != null)
                {
                    while (fast_ptr != null &&
                           fast_ptr.Next != null)
                    {
                        fast_ptr = fast_ptr.Next.Next;
                        slow_ptr = slow_ptr.Next;
                    }
                    Console.WriteLine("The middle element is [" +
                                      slow_ptr.Value + "] \n");
                }
            }

            //Total number of nodes
            public void GetCount()
            {
                Node temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }
                Console.WriteLine("Total number of nodes are {0}", count);
            }

            //reverse the linked list
            public void ReverseList()
            {
                Node prev = null, current = head, next = null;
                while (current != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }
                head = prev;
            }

            //Sorting


            //Printing
            public void PrintAllNodes()
            {
                //Traverse from head
                Console.Write("Head ->");
                Node curr = head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    Console.Write(curr.Value);
                    Console.Write("->");
                }
                Console.Write("NULL");
            }

        }



        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Adding few elemnts and traversing");
            lnklist.AddAtLast(12);
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Peter");
            lnklist.AddAtLast(34);
            lnklist.AddAtLast(45);
            lnklist.AddAtLast("Tony");
            lnklist.AddAtLast("Steve");
            lnklist.AddAtLast(78);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Adding at start");
            lnklist.AddAtStart(55);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Adding at position");
            lnklist.AddAtPosition(56, 4);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Removing at start");
            lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Removing at last");
            lnklist.RemoveAtLast();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Removing at position");
            lnklist.RemoveAtPosition(3);
            lnklist.PrintAllNodes();
            Console.WriteLine();            

            Console.WriteLine("Printing Middle Element");
            lnklist.PrintMiddle();
            Console.WriteLine();

            Console.WriteLine("Total number of nodes");
            lnklist.GetCount();
            Console.WriteLine();

            Console.WriteLine("Reversing the linked list");
            lnklist.ReverseList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
