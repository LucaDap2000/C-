namespace Break_and_Continue_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void Run()
        {
            int i = -10;

            while (true)
            {
                if(i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if(i == 10)
                {
                    break;
                }
                if(i == 11)
                {
                    Console.WriteLine("FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                Console.WriteLine(i++);
            }
        }

    }
}