using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_in_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Hello World!");
            boxStr.UpdateContent("Teaching C# is fun");
            Console.WriteLine(boxStr.GetContent());

            Console.ReadKey();
        }
    }
}
