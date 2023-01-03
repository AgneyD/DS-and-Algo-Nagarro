using System;

namespace Stack_Implementation
{
    class Program
    {
        internal class Stack
        {
            static readonly int MAX = 1000;
            int top;
            int[] stack = new int[MAX];

            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }

            //Push
            internal bool Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            //Pop
            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }

            //Peek
            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }

            //Contains
            internal void Contains(int data)
            {
                int present = 0;
                int position = int.MinValue;
                for (int i = 0; i < stack.Length; i++)
                {
                    if (stack[i] == data)
                    {                        
                        present = 1;
                        position = i+1;
                        break;
                    }                    
                }
                if (present == 1)
                {
                    Console.WriteLine("{0} is present at {1} position", data, position);
                }
                else
                {
                    Console.WriteLine("{0} is not present in the stack", data);
                }
            }

            //Size
            internal int Size()
            {
                int Size = top+1;
                return Size;
            }

            //Middle Element
            internal void MiddleElement()
            {
                int Mid; 

                if (top < 0)
                {
                    Console.WriteLine("No element present");
                    return;
                }
                else
                {
                    Mid = (top + 1) / 2;
                    Console.WriteLine("Middle element of the stack is {0}", stack[Mid]);
                }
            }

            //internal void Reverse()
            //{
            //    int[] revStack = new int[MAX];
            //    int revTop;
            //    void Push(int data)
            //    {
            //        revStack[++revTop] = data;
            //    }

            //    while (top<0)
            //    {
            //        int newData = ;

            //    }
            //}

            //Print
            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);
            myStack.Push(60);
            myStack.Push(70);            
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
            myStack.Contains(50);
            Console.WriteLine("Size of stack is {0}", myStack.Size());
            myStack.MiddleElement();

        }
    }
}
