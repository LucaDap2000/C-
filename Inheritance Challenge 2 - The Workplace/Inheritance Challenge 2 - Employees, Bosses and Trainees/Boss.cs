using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2___Employees__Bosses_and_Trainees
{
    // Boss inherits from the Employee class
    internal class Boss : Employee
    {
        // Create CompanyCar property
        public string CompanyCar { get; set; }

        // Create the constructor for new property and inherit the other constructors from the base class 
        public Boss(string companyCar, string name, string firstName, int salary) : base (name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        // Create Lead() method
        public void Lead()
        {
            Console.WriteLine("I'm the boss! My name is {0} {1}", FirstName, Name);
        }
    }
}
