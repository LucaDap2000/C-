using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Generic_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> sum = (x, y) =>
            {
                return "Your result is: " + (x + y).ToString();
            };

            Console.WriteLine(sum(3,5));

            Console.ReadKey();
        }
    }
}
