using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code___Method_Structuring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor();

            Order order = new Order();

            // The if statement below without braces is fine when only one line of code is being executed

            if(orderProcessor.IsValid(order))
                Console.WriteLine("Order is valid");

            // It is good practice to always use braces

            if (orderProcessor.IsValid(order))
            {
                Console.WriteLine("Order is valid");
            }

            foreach(int i in new int[1, 2, 3])
            {
                Console.WriteLine(i);
            }
        }
    }
}
