using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Car
    {
        // Member variable
        private string _name; // private field typically used for storing data
        private int _hp;
        private string _colour;

        // Default constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
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
            Drive();
        }

        // Full specification constructor
        public Car(string name, int hp, string colour)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _colour = colour;
            Drive();
        }

        // Member method
        private void Drive()
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
