using System.Transactions;

namespace Challenge_2___Stringsanditsmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            // Read first input string
            string input = Console.ReadLine();

            Console.WriteLine("Enter a character to search: ");
            // Read input character
            char searchInput = Console.ReadLine()[0];
            // Gets the index of the character from the string
            int searchIndex = input.IndexOf(searchInput);
            // Prints the index as a search result on console
            Console.WriteLine("The index of character {0} in the input string is {1} ", searchInput, searchIndex);

            // Using concatination
            Console.WriteLine("Enter first name: ");
            // Read first name 
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            // Read last name
            string lastName = Console.ReadLine();

            // Concatinate the first and last name variables into one full name variable
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is: {0}", fullName);

            Console.ReadKey();
        }
    }
}