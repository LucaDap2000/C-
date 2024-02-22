using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2___Employees__Bosses_and_Trainees
{
    // Trainee inherits from the Employee class
    internal class Trainee : Employee
    {
        // Create properties for the Trainee class
        public int WorkingHours { get; set; }
        public int StudyHours { get; set; }

        // Create the constructor
        public Trainee(int workingHours, int studyHours, string name, string firstName, int salary) : base (name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.StudyHours = studyHours;
        }

        // Create a method to Learn
        public void Learn()
        {
            Console.WriteLine("I've studied for {0} hours!", StudyHours);
        }

        // Create a method to Work
        public new void Work() // Learn more about this when we move onto Polymorphism
        {
            Console.WriteLine("I worked for {0} hours!", WorkingHours);
        }
    }
}
