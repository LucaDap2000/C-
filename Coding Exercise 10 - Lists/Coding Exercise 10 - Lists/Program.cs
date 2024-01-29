using System;
using System.Collections.Generic;
namespace Coding_Exercise_10___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (int i = 100; i < 171; i += 2)
            {
                list.Add(i);
            }

            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            Console.Read();

        }

        public static List<int> Solution()
        {
            var list = new List<int>();

            for (int i = 100; i < 171; i += 2)
            {
                list.Add(i);
            }

            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            return list;

        }
    }
}
