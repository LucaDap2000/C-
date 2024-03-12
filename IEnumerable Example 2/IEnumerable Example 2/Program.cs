using System;
using System.Collections.Generic;
namespace IEnumerable_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A list of type List<int> initialised with some number
            List<int> numberList = new List<int>() { 8, 6, 2 };
            // An array of type int[] initialised with some numbers
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            // New line
            Console.WriteLine(" ");
            // Call CollectionSum() and pass the list to it
            CollectionSum(numberList);

            Console.WriteLine(" ");
            // Call CollectionSum() and pass the array to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // Sum variable to store the sum of the numbers in anyCollection
            int sum = 0;

            // For each number in the collection passed to this method
            foreach (int num in anyCollection)
            {
                // Add the num value to the sum
                sum += num;
            }

            // Print the sum
            Console.Write("The sum is {0}", sum);
        }
    }
}
