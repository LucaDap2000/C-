namespace SpecialCharactersInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is a \"string\" with a slash / and a colon: ";
            string s2 = "This is a \"string\" with \na backslash \\ and a colon: ";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}