using System.Threading.Channels;

namespace Delegates_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----before----");
            // Print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Calling RemoveAll and passing a method Filter we created
            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            // Print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // A method called Filter that takes a string
        static bool Filter(string s)
        {
            // Return whether the string s contains the letter 'i'
            // The Contains method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}
