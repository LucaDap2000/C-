using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Generic_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (x) =>
            {
                return x % 2 == 0;
            };

            Console.WriteLine(isEven(5));

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var evenInts = ints.FindAll(isEven);

            Console.ReadKey();
        }
    }
}
