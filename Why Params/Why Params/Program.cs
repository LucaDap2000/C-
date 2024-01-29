namespace Why_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Sum(1, 2, 3);
            int sum2 = Sum(4, 5, 6, 7, 8);
            int sum3 = Sum();

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            double average1 = Average(1, 2, 3);
            double average2 = Average(4, 5, 6, 7, 8);
            double Average3 = Average();

            Console.WriteLine(average1);
            Console.WriteLine(average2);
            Console.WriteLine(Average3);
        }

        // Declare a method that uses the "params" keyword

        public static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;

        }

        // Declare a method that uses the "params" keyword and calculates the average

        public static double Average(params int[] numbers)
        {
            int total = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                total += number;
                count++;
            }

            return (double)total / count;

        }
    }
}
