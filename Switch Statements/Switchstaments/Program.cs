namespace Switchstaments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            string username = "Luca";

            switch(username)
            {
                case "Luca":
                    Console.WriteLine("username is Luca");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }

            Console.Read();

        }
    }
}