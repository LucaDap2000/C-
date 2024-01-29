using System.Runtime.CompilerServices;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int counter = 0; counter < 10; counter += 5)
            //++ increments up, -- increments down, += will add a number
            {
                Console.WriteLine(counter + "is lower than 10");
            }
            Console.WriteLine("For loop is done");
            Console.Read();
            */
            for (int numbers = 1; numbers % 2 != 0 && numbers < 20; numbers+=2)
            {
                Console.WriteLine("The number {0} is odd", numbers);
            }
            Console.Read();
        }
    }
}