namespace ImplicitExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int num = 1278375;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // Explicit conversion
            // Cast double to int;
            myInt = (int)myDouble;

            // Type conversion
            string myString = myDouble.ToString();  // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}