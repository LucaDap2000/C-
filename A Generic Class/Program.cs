using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Generic_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Content = 1;
            Console.WriteLine(box.Log());

            Box<string> boxStr = new Box<string>();
            boxStr.Content = "Hello World!";
            Console.WriteLine(boxStr.Log());

            Console.ReadKey();
        }
    }
}
