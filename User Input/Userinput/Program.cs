using System.Threading.Channels;

namespace Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();

            // Create addition code (my attempt)

            // string num1;
            // string num2;

            // Console.WriteLine("Please input a number here: ");
            // num1 = Console.ReadLine();
            // int num1Parsed = Int32.Parse(num1);
            // Console.WriteLine("Please input another number here: ");
            // num2 = Console.ReadLine();
            // int num2Parsed = Int32.Parse(num2);
            // int addition = num1Parsed + num2Parsed;
            // Console.WriteLine(addition);
        }
        
            // Create addition code (solution)

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string number2Inuput = Console.ReadLine();

            int num1 = Int32.Parse(number1Input);
            int num2 = Int32.Parse(number2Inuput);

            int result = num1 + num2;
            return result;
        }

    }
}