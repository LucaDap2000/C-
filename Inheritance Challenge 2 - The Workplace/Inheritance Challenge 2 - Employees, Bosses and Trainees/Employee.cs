using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2___Employees__Bosses_and_Trainees
{
    internal class Employee
    {
        // Employee properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        // Create the constructor
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        // Create default constructor
        public Employee()
        {
            Name = "D'Aprano";
            FirstName = "Luca";
            Salary = 50000;
        }

        // Create Work method
        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        // Create Pause method
        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
