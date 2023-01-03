using System;

namespace Queue
{
    class LinearQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public LinearQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        //Enqueue
        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        //Dequeue
        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);
                return ele[front++];
            }
        }

        //Peek
        public void Peek()
        {
            if(front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Front Element is: {0}", ele[front]);
        }

        //size
        public void Size()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Size of Queue at present is {0}", front+1);
        }

        //Contains
        public void Contains(int data)
        {
            int present = 0;
            int position = int.MinValue;
            for (int i = 0; i < max; i++)
            {
                if (ele[i] == data)
                {
                    present = 1;
                    position = i + 1;
                    break;
                }
            }
            if (present == 1)
            {
                Console.WriteLine("{0} is present at {1} position", data, position );
            }
            else
            {
                Console.WriteLine("{0} is not present in the queue", data);
            }
        }

        //Center
        public void Center()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Middle element of Queue is {0}", ele[max/2]);
        }

        //reverse


        //print
        public void PrintQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinearQueue Q = new LinearQueue(5);

            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);
            Q.Enqueue(50);

            Console.WriteLine("Items are : ");
            Q.PrintQueue();

            Q.Dequeue();
            Q.Dequeue();

            Console.WriteLine("Items are : ");
            Q.PrintQueue();

            Q.Peek();
            Q.Size();
            Q.Contains(40);
            Q.Center();

        }
    }
}
