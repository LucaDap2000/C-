using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_Parameters
{
    internal class Audi : Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string colour, string model) : base(hp, colour)
        {
            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + Brand + " HP:" + HP + " Colour:" + Colour);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
