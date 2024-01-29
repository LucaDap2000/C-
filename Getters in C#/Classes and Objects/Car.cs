using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Car
    {
        // Priavte member variable/field(s)
        private string _name; // private field typically used for storing data
        private int _hp;
        private string _colour;

        // Public property
        public string Name
        {
            get { return _name; }  // Get accessor
            set
            {
                if (value == "")
                {
                    _name = "Hello World Default Name";
                }
                else
                {
                    _name = value;
                }
            }
        }  // Set accessor

        // Default constructor
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _colour = "red";
            Drive();
        }

        // Partial specification constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _colour = "red";
        }

        // Full specification constructor
        public Car(string name, int hp, string colour)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _colour = colour;
        }

        // Member method
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        // Member method
        public void Details()
        {
            Console.WriteLine("The " + _colour + " car " + _name + " has " + _hp + " hp ");
        }

        // Member method
        public void Stop()
        {
            Console.WriteLine(_name + " Stopped!");
        }
    }
}
