namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Luca";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}