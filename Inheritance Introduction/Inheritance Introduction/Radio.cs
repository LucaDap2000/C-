using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction
{
    // Child class
    internal class Radio : ElectricalDevice
    {
        // Simple constructor
        public Radio (bool isOn, string brand) : base (isOn, brand)
        {
            
        }

        // Method to listen to the radio
        public void ListenRadio()
        {
            // First check if the radio is on
            if (IsOn)
            {
                // Listen to the radio
                Console.WriteLine("You are listening to the radio!");
            }
            else
            {
                // Print error message
                Console.WriteLine("The radio is switched off, please switch it on to listen.");
            }
        }
    }
}
