using System;
using System.Collections.Generic;
namespace Stacks_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining a new stack
            Stack<int> stack = new Stack<int>();

            // Add elements to the stack using Push()
            // Adding elements to the stack and printing the value on top of the stack using Peek()

            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            // Pop() will remove the item and return the item

            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item: {0}", myStackItem);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            // First check the stack length is > 0 / check the stack is not empty

            while (stack.Count > 0)
            {
                // Pop() will return the element that was removed from the stack
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());
                // Print the stack count
                Console.WriteLine("The current stack count is: {0}", stack.Count);
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            // Defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are:");

            // foreach number in our array
            foreach (int number in numbers)
            {
                // Print it
                Console.Write(number + " ");
                // Push it into our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse:");
            // As long as our stack is not empty

            while (myStack.Count > 0)
            {
                // Pop it and store it in a variable
                int number = myStack.Pop();
                // Print the value we popped
                Console.Write(number + " ");
            }
        }
    }
}
