namespace Assignment1_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = Int32.Parse(stringForInt);

            Console.WriteLine("Int = {0}, Float = {1}", myInt, myFloat);
        }
    }
}