using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_Parameters
{
    internal class BMW : Car
    {
        // A BMW is a car
        private string Brand = "BMW";
        public string Model { get; set; }
        
        public BMW (int hp, string colour, string model) : base (hp, colour)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand:" + Brand + " HP:" + HP + " Colour:" + Colour);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }
    }
}
