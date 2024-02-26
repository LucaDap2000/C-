using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating___Using_Interfaces
{
    // Child class Chair that inherits from Furniture
    internal class Chair : Furniture, IDestroyable
    {
        // Implementing the interfaces property
        public string DestructionSound {  get; set; }

        // Simple constructor
        public Chair(string colour, string material)
        {
            this.Colour = colour;
            this.Material = material;

            // Initialising the interfaces property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        // Implementing the interfaces method
        public void Destroy()
        {
            // When a chair gets destroyed we should play the destruction sound
            // and spawn the destroyed chair parts
            Console.WriteLine($"The {Colour} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
