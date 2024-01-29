using Microsoft.VisualBasic;

namespace Challenge___Datatypesandvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte mySbyte = -128; // sbyte is from -128 to 128
            short myShort = -32768; // short is from -32,768 to 32,768
            int myInt = -2147483648; // Int is from -2,147,483,647 to 2,147,483,647
            long myLong = -9223372036854775808; // long is from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,808

            // Choose the smallest type your value fits into

            float myFloat = 0.5f; // float is from 1.5x10^-45 to 3.4x10^38 (three sig figs)
            double myDouble = 0.5; // double is from 5.0x10^-324 to 1.7x10^308 (15 sig figs)
            decimal myDecimal = 0.5m; // decimal is from -7.9x10^-28 to 7.9x10^28 (28 sig figs)

            // Use float for 3D graphics, double for everything (except money calculations) and decimal for financial applications

            bool myBool = false;

            // Use a boolean for true/false results

            char c = 'a'; // define character variable
            string myString = "Luca D'Aprano"; // define string variable

            // Use strings for paths, username, birthdate etc.

            string myString1 = "I control text";
            string myString2 = "8";
            int parseString = Int32.Parse(myString2); // Parse myString2

            Console.WriteLine(myString1 + " " + parseString); // Write a concatinated string

            Console.ReadKey();
        }
    }
}