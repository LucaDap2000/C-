using System.Diagnostics.Tracing;
using System.IO;
namespace Assignment___Parsing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Luca D'Aprano\OneDrive\Documents\input.txt");

            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(' ');
                    File.WriteAllText(@"C:\Users\Luca D'Aprano\OneDrive\Documents\output.txt", words[4]);
                }
            }

            Console.ReadKey();
        }
    }
}
