using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_Without_GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log<int>(10);
            logger.Log<string>("Hello World!");

            logger.Log(new {Name = "John", Age = "30"});

            Console.ReadKey();
        }
    }
}
