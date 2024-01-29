namespace NestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username: ");
            userName = Console.ReadLine();

            if(isRegistered)
            // You could also do: if(isRegistered && userName != "" && userName.Equals("admin"))
            // This means you could use the AND operator logic instead of multiple if statements
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, admin");
                    }
                }
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();

        }
    }
}