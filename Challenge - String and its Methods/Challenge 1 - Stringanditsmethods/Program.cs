namespace Challenge_1___Stringanditsmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString;
            myString = "Luca";
            Console.WriteLine("Please enter your name and press enter");
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Trim());
            Console.WriteLine(myString.Substring(0));
        }
    }
}