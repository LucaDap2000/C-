namespace CodingExercise2___Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check(0);
        }

        public static void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }
        }

    }
}