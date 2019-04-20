using System;
using static System.Console;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("== Stack Program == ");

            WriteLine("\n============= Int  Generic Stack ==============");
            // Adding int items on to stack

            Stack<int> intStack = new Stack<int>(5);

            WriteLine("\nIs Stack Full? " + intStack.isFull());

           
            // Push Item to Stack
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);
            intStack.Push(40);
            intStack.Push(50);
            intStack.Push(60);

            
            // Remove item from Stack
            // intStack.Pop();
            // intStack.Pop();
           
            // Peek Current Item on Stack
            intStack.Peek();

            // Push item to Stack
            intStack.Push(100);
            

            // Peek Current item to Stack
            intStack.Peek();

            // Show Stack items
            WriteLine("\nItems on Stack:");

            while(!intStack.isEmpty())
            {
                WriteLine(intStack.Pop());
                
            }

            WriteLine("\nIs Stack Empty? " + intStack.isEmpty());


            // Adding String item on to Stack

            WriteLine("\n============= String  Generic Stack ==============");

            Stack<string> strStack = new Stack<string>(6);

            WriteLine("\nIs Stack Full? " + intStack.isFull());

            //Push Item to Stack
            strStack.Push("One");
            strStack.Push("Two");
            strStack.Push("Three");
  
            // Remove item from Stack
            // strStack.Pop();
            // strStack.Pop();

            // Peek Current Item on Stack
            strStack.Peek();

            // Push item to Stack
            strStack.Push("Four");
            strStack.Push("Five");

            // Peek Current item to Stack
            strStack.Peek();

            // Show Stack items
            WriteLine("\nItems on Stack:");

            while(!strStack.isEmpty())
            {
                WriteLine(strStack.Pop());
                
            }

            WriteLine("\nIs Stack Empty? " + strStack.isEmpty());

             

            Console.ReadLine();
             
        }
    }

    public class Stack<T> {
        private int maxSize;
        private int top = -1;
        private T[] StackArray;
        
        public Stack(int size)
        {
             maxSize = size;
             top = -1;
             StackArray = new T[maxSize];
        }

        public void Push(T item)
        {
            if(isFull())
            {
                WriteLine("\nCan't add item {0}", item);
                WriteLine("Push: Stack is full");
            }
            else
            { 
                WriteLine("Adding item {0} to stack", item);
                top++;
                StackArray[top] = item;
            }
        }

        public T Pop()
        {
            if(isEmpty())
            {
                WriteLine("\nPop: Stack is Empty");
                return StackArray[0];
            }
            else 
            { 
                int old_top = top;
                top--;
                return StackArray[old_top];
            }
            
        }

        public void Peek()
        {
            if(isEmpty()) 
            {
                WriteLine("\nPeek: Stack is Empty.");
            }
            else
            { 
               WriteLine("\nCurrent Stack Item at {0} position is {1}", top, StackArray[top]);
            }
   
        }

        public Boolean isFull()
        {
            // Array Starts with Zero, so need to do maxSize-1
            return (top == maxSize-1);
        }

        public Boolean isEmpty()
        {
            return (top == -1);
        }
    }
}
