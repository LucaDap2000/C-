namespace Read_From_a_Text_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\Luca D'Aprano\OneDrive\Documents\ReadFromTextFile.txt");

            Console.WriteLine("Text file contains the following text: {0}", text);

            //Example 2
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Luca D'Aprano\OneDrive\Documents\ReadFromTextFile.txt");

            Console.WriteLine("Contents of textfile.txt = ");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
        }
    }
}
