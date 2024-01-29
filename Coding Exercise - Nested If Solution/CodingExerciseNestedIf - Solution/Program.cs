namespace CodingExerciseNestedIf___Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NestedCheck(0);
        }
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                if (number % 2 != 0)
                    Console.WriteLine("Odd number.");
                else
                    Console.WriteLine("Even number.");
            }
        }
    }
}