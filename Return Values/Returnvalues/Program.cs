namespace Returnvalues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(12, 12));
            Console.WriteLine(Divide(25, 13));
            Console.Read();
        }
        
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}