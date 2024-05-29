using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code___Nomenclature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bad example
            int n = 0;
            string s = "John";

            // Good example
            int studentCount = 100;
            string studentName = "John";
        }

        class CustomerService // PascalCase used for classes, interfaces, public properties and methods
        {
            public const int MAX_CUSTOMERS = 100; // ALL_CAPS

            public int CustomerCount { get; set; } // All words in the name capitalised

            private string lastCustomerName = "John"; // camelCase used for private fields, local variables and parameters

            public string GetCustomerName(int customerId) // camelCase
            {
                string customerName = "John Doe"; // camelCase
                return customerName;
            }
        }

        class CustomerSatisfaction
        {
            private string _customerName = "JohnDoe";

            public CustomerSatisfaction(string customerName)
            {
                _customerName = customerName;
            }

            // Or use the following:

            /*
            public CustomerSatisfaction(string customerName)
            {
                this.customerName = customerName;
            }
            */
        }

        class OrderProcessor // Nouns for class names
        {
            public void ProcessOrder() // Use verbs for method names
            {

            }

            public void PrintOrder()
            {

            }

            public void DeleteOrder()
            {

            }

            // Boolean names should be questions that can be true or false by using has or is

            private bool hasErrors = false;

            private bool isValid = true;
        }

        class CustomerReviews
        {
            // Should use Is, Get, Set, Has, Can... in method names i.e.,

            public void SetCustomerName()
            {

            }

            public bool HasErrors()
            {
                return false;
            }

            public bool CanReceiveEmails()
            {
                return false; 
            }

            // Bad example
            public void Save()
            {

            }

            // Good examples 
            public void SaveCustomer()
            {

            }

            public void SaveCustomerName() // Be precise and include the noun in the method name too
            {

            }
        }
    }
}
