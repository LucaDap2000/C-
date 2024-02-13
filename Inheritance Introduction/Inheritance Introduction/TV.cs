using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction
{
    // Child class
    internal class TV : ElectricalDevice
    {
        // Simple constructor
        public TV (bool isOn, string brand) : base (isOn, brand)
        {

        }

        // Method to watch the TV
        public void WatchTV()
        {
            // First check if the TV is on
            if (IsOn)
            {
                // Watch the TV
                Console.WriteLine("You are watching the TV!");
            }
            else
            {
                // Print error message
                Console.WriteLine("The TV is switched off, please switch it on to watch.");
            }
        }
    }
}
