using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_Parameters
{
    internal class Car
    {
        public int HP { get; set; }
        public string Colour { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car (int hp, string colour)
        {
            this.HP = hp;
            this.Colour = colour;
        }

        // Default constructor
        public Car()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("HP:" + HP + " Colour:" + Colour);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
