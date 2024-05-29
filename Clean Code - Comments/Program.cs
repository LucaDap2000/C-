using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code___Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// A class with two methods that perform mathematical calculations
        /// The CalculateFactorial method returns the factorial result of a number
        /// The BinarySearch method finds a target number within an array
        /// </summary>

        public class MathUtils1
        {

            // Comment

            /*
             * 
             * 
             */

            // We are using a recursive approach here BECAUSE it's more intuitive: Always explain why you are doing something not just what is happening

            /// <summary>
            /// 
            /// </summary>
            /// <param name="number">The integer which we will calculate the factorial of</param>
            /// <returns>Return the result of the factorial</returns>
            public int CalculateFactorial(int number)
            {
                if (number <= 1)
                    return 1;
                else
                    return number * CalculateFactorial(number - 1);
            }

            // Using binary search here to improve the performance for large datasets

            // Only add comments when necessary, if you do not need to then don't
            public int BinarySearch(int[] sortedArray, int target)
            {
                int left = 0;
                int right = sortedArray.Length - 1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (sortedArray[middle] == target)
                        return middle;
                    else if (sortedArray[middle] < target)
                        left = middle + 1;
                    else
                        right = middle - 1;
                }

                return -1;
            }
        }

        public class MathUtils2
        {
            // TODO: Implement the binary search algorithm: Use TODO: to show that you have not finished/started implementing something

            // Using TODO: also places the comment in the task list so it is clear for anyone to see which sections are still in progress
            public int BinarySearch()
            {
                return -1;
            }
        }
    }
}
