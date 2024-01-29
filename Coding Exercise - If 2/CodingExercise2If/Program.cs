namespace CodingExercise2If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check(0);
        }

        public static void Check(int number)
        {
            Console.WriteLine("Please enter a whole number here: ");
            string inputNumber = Console.ReadLine();
            int inputNumberAsInt;

            if(int.TryParse(inputNumber, out number))
            {
                inputNumberAsInt = number;

                if(number >= 0 || number <= 0)
                {
                    int num2 = 2;
                    int result;
                    result = number % num2;
                    
                    if(result == 0)
                    {
                        Console.WriteLine("Even");
                        Console.Read();
                    }

                    else
                    {
                        Console.WriteLine("Odd");
                        Console.Read();
                    }
                }
            }
        }
    }
}