using System.Security.Cryptography.X509Certificates;

namespace Codingexercise1___Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s)
        {
            Console.WriteLine("The amount of characters is {0}", s.Length);
        }

        public static void Run()
        {
            string s = "Hey ThErE !";

            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }

    }
}