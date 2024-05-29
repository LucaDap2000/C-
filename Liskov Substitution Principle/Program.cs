using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    // We should be able to replace derived classes with base classes without causing errors
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Sparrow();
            sparrow.MakeSound();
            ((IFlyable)sparrow).Fly();

            Bird penguin = new Penguin();
            penguin.MakeSound();
        }

        public class Bird
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Chirp");
            }
        }

        public class Penguin : Bird
        {
            public override void MakeSound()
            {
                base.MakeSound();
            }
        }

        public class Sparrow : Bird, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Flying");
            }
        }

        public interface IFlyable
        {
            void Fly();
        }
    }
}
