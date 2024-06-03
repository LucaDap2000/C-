using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Generics_in_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(100, "One Hundred");
            box.Display();

            Console.ReadKey();
        }
    }
}
