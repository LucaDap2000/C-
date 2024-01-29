namespace Coding_Exercise_4___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
        }
        public static void ForLoop()
        {
            for (int incrementCounter = -3; incrementCounter < 4; incrementCounter++)
            {
                Console.WriteLine(incrementCounter);
            }
        }
        public static void WhileLoop()
        {
            int incrementCounter = -3;
            while (incrementCounter > -4 && incrementCounter < 4)
            {
                Console.WriteLine(incrementCounter++);
            }
        }
    }
}