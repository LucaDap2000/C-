using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints_For_Generic_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product();
            var productTwo = new Product();

            var result = Comparer.AreEqual(productOne, productTwo);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Product()
    {

    }
}
