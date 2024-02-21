using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override
{
    internal class Dog : Animal
    {
        // Boolean property to check if the dog is happy
        public bool IsHappy { get; set; }

        // Simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            // All dogs are happy :)
            IsHappy = true;
        }

        // Simple override of the virtual method Eat
        public override void Eat()
        {
            // To call the Eat method from our base class we use the keyword "base"
            base.Eat();
        }

        // Override of the virtual method MakeSound
        public override void MakeSound()
        {
            /* Since every animal will make a different sound
             * each animal will implement their own version of MakeSound
            */
            Console.WriteLine("Woooof!");
        }

        // Override of the virtual method Play
        public override void Play()
        {
            // Check if the dog is happy, if true call the Play method from the base class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
