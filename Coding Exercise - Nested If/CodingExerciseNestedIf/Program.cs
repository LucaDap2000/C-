using System.ComponentModel.Design;

namespace CodingExerciseNestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NestedCheck(0);
        }
        public static void NestedCheck(int number)
        {
            Console.WriteLine("Please input a whole number here: ");
            string inputNumber = Console.ReadLine();
            int inputNumberAsInt;

            if (int.TryParse(inputNumber, out number))
            {
                inputNumberAsInt = number;
                int evenDivisor = 2;
                int divisorNum = 3;
                int divisorNum2 = 7;
                int result;
                result = number % divisorNum;

                if (result == 0)
                {
                    Console.WriteLine("Divisible by 3.");
                }

                else if (result != 0)
                {
                    result = number % divisorNum2;

                    if (result == 0)
                    {
                        Console.WriteLine("Divisible by 7.");
                    }
                    
                else if(result != 0)
                    {
                        result = number % evenDivisor;

                        if (result == 0)
                        Console.WriteLine("Even number.");

                        else if(result != 0)
                        {
                            Console.WriteLine("Odd number.");
                        }
                    }
                }

                Console.Read();

            }
        }
    }
}