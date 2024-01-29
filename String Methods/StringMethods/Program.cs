using System.Globalization;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Luca";
            string lastName = "D'Aprano";
            string fullName = string.Concat("", firstName, lastName, "");
            Console.WriteLine(firstName.Substring(2)); // output: "ca"
            Console.WriteLine(firstName.ToLower()); // Output: "luca"
            Console.WriteLine(firstName.ToUpper()); // Output: "LUCA"
            Console.WriteLine(fullName.Trim()); // Output: "LucaD'Aprano"
            Console.WriteLine(firstName.IndexOf('u')); // Output: 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); // Output: False

            // String.Format is used to insert the object or variable value inside any string
            string myString = String.Format("My name is {0}", firstName); // Here the string name will be replaced at index {0} in the string and the output will be "My name is Luca"
            Console.WriteLine(myString);
        }
    }
}