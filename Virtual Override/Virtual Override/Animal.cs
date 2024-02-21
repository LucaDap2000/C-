using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override
{
    internal class Animal
    {
        // Name property
        public string Name { get; set; }

        // Age Property
        public int Age { get; set; }

        // Is hungry boolean to check whether the animal is hungry
        public bool IsHungry { get; set; }

        // Simple constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        // An empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        // A virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            // Check if animal is hungry
            if (IsHungry)
            {
                // If true then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                // If false then print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        // A virtual method called Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
