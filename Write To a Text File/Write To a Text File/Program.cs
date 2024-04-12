using System.IO;
namespace Write_To_a_Text_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"C:\Users\Luca D'Aprano\OneDrive\Documents\highscores.txt", lines);

            // Method 2
            Console.WriteLine("Please give the file a name");
            Console.WriteLine("Please enter the file contents");
            string fileName = Console.ReadLine();
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Luca D'Aprano\OneDrive\Documents\" + fileName + ".txt", input);

            // Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\Luca D'Aprano\OneDrive\Documents\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\Luca D'Aprano\OneDrive\Documents\highscores.txt", true))
            {
                file.WriteLine("Additional line");
            }
        }
    }
}
