using System.Globalization;

namespace Codingexercise1___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpperLower("I will return the joined result of the input string in lower and upper case");
            Count(0);
        }

        // Part 1

        public static void UpperLower(string upperLowerString)
        {
            string inputString;
            string lowerString;
            string upperString;

            Console.WriteLine("Input string here: ");
            inputString = Console.ReadLine();
            lowerString = inputString.ToLower();
            upperString = inputString.ToUpper();
            upperLowerString = string.Concat(lowerString, upperString);
            Console.WriteLine(upperLowerString);
        }

        // Part 2

        public static void Count(int totalCharacters)
        {
            string inputString;

            Console.WriteLine("Input string here: ");
            inputString = Console.ReadLine();
            totalCharacters = inputString.Length;
            Console.WriteLine("The amount of characters is {0}", totalCharacters);
        }

    }
}