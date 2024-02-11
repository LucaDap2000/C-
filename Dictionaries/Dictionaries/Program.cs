using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
namespace Dictionaries
{
    internal class Program
    {
        // key - value
        // Macchina - car

        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95,200),
                new Employee("Manager", "Joe", 35,25),
                new Employee("HR", "Lora", 32,21),
                new Employee("Secretary", "Petra", 28,18),
                new Employee("Lead Developer", "Luca", 55,35),
                new Employee("Intern", "Ernest", 22,8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            for ( int i = 0; i < employeesDirectory.Count; i++)
            {
                // Using Elementat(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                // Print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);

                // Storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;

                // Printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", key);
            }

            Employee result = null;

            // Using TryGetValue() it returns true if the operation was successful and false otherwise
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }
        }

        class Employee
        {
            // Define a few properties like role, name, age and rate

            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }

            // Yearly Salary = rate/h * number of weeks * number of months
            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;
                }
            }

            // simple constructor

            public Employee(string role, string name, int age, float rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }
        }
    }
}
