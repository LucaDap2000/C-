using Clean_Code___Formatting.Models;
using Clean_Code___Formatting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code___Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    /// <summary>
    /// The class should be formatted in the following order:
    /// Properties
    /// Fields
    /// Constructor
    /// Methods
    /// </summary>

    // Good formatted example
    public class AdminName
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    // Bad example
    public class UserName
    {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public void PrintFullName()
    {
    Console.WriteLine($"{FirstName} {LastName}");
    }
    }
}
