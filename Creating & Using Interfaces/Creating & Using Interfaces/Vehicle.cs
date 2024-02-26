using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating___Using_Interfaces
{
    // Parent class for vehicles
    internal class Vehicle
    {
        // Speed of the vehicle
        public float Speed { get; set; }
        // Colour of the vehicle
        public string Colour { get; set; }

        // Default constructor
        public Vehicle()
        {
            Speed = 120f;
            Colour = "White";
        }

        // Simple constructor
        public Vehicle (float speed, string colour)
        {
            Speed = speed;
            Colour = colour;
        }
    }
}
