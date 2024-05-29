using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    // It is good practice to split up the interface into its constituent methods if classes inherit properties that they do not/cannot use

    internal class Program
    {
        static void Main(string[] args)
        {
            Worker human = new Worker();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();
            // robot.Eat(); We cannot do this
        }

        public interface IWorkable
        {
            void Work();
        }

        public interface IEatable
        {
            void Eat();
        }

        public class Worker : IWorkable, IEatable
        {
            public void Work()
            {
                Console.WriteLine("Working");
            }

            public void Eat()
            {
                Console.WriteLine("Eating");
            }
        }

        public class Robot : IWorkable
        {
            public void Work()
            {
                Console.WriteLine("Working");
            }
        }
    }
}
