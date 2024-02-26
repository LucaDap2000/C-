using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating___Using_Interfaces
{
    // Parent class for items of furniture
    internal class Furniture
    {
        // Colour of the furniture
        public string Colour { get; set; }
        public string Material { get; set; }

        // Default constructor
        public Furniture()
        {
            Colour = "White";
            Material = "Wood";
        }

        // Simple constructor
        public Furniture (string colour, string material)
        {
            Colour = colour;
            Material = material;
        }
    }
}
