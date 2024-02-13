using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction
{
    // Parent class
    internal class ElectricalDevice
    {
        // Boolean to determine the state of the electrical device
        public bool IsOn {  get; set; }
        // String for the brand name of the electrical device
        public string Brand { get; set; }

        // Simple constructor

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // Switch on the electrical device
        public void SwitchOn()
        {
            IsOn = true;
        }
        // Switch off the electrical device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
