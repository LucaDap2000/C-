namespace Assignment1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            int i = Int32.Parse(stringForInt);
            float f = float.Parse(stringForFloat);

            System.Console.WriteLine("Int = {0}, Float = {1}", i, f);
        }
    }
}