namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change throughout the program

    internal class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        // Create a constant of type string with your birthday as its value
        const string myBirthday = "15th of February 2000";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is {0} ", myBirthday);
            Console.ReadKey();
        }
    }
}