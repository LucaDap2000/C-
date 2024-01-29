namespace Coding_Exercise_8___Arrays__for_and_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

            public static void GetOdd(int[] Array)
            {
                for(int i = 1; i <= Array.Length; i += 2)
            {
                Console.WriteLine(i);
            }

            }

            public static void GetEven(int[] Array)
            {
                for(int i = 0; i <= Array.Length; i += 2)
            {
                Console.WriteLine(i);
            }

            }

            public static void Run()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                GetOdd(array);
                GetEven(array);

            }

    }
}
