namespace Why_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Use foreach to perform an operation on each element in an array without manipulating the index
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Use for when you need more control over the iteration process
            for(int i = 0; i < numbers.Length; i+= 2)
            {
                Console.WriteLine(numbers[i]);
            }

            // Use while when you do not know how many times you will need to loop
            string input;
            do
            {
                Console.WriteLine("Please enter a valid number:");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out _));
        }
    }
}
