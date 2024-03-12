using System;
using System.Collections.Generic;
namespace IEnumerable_Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a generic IEnumerable variable that takes any collection of type int
            // We will use this variable to store the collections that will get returned by the GetCollection() method
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            // Create new line
            Console.WriteLine("");

            // Call GetCollection() with option = 2 which will return a Queue<int>
            // But we will store it in the base type of generic collections
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            
            // For each number in the collection we got back from GetCollection(2)
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unknownCollection = GetCollection(5);

            Console.WriteLine("This was an array of int");

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // Create a list of numbers and initialise it
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            // Add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            // If the option is 1
            if (option == 1)
            {
                // Return the list of type List<int>
                return numbersList;
            }
            // If the option is 2
            else if (option == 2)
            {
                // Return the queue of type<int>
                return numbersQueue;
            }
            // Otherwise
            else
            {
                // Return an array of numbers initialised with some numbers
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
