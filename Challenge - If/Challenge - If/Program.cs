namespace Challenge___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateLogin();
            Console.Read();
        }

        public static void CreateLogin()
        { 
            string userName = "";
            string password = "";
            Console.WriteLine("Please enter a new username here: ");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter a new password here: ");
            password = Console.ReadLine();
            string userNameLogin = "";
            string passwordLogin = "";
            Console.WriteLine("Please enter your username here: ");
            userNameLogin = Console.ReadLine();
            Console.WriteLine("Please enter your password here: ");
            passwordLogin = Console.ReadLine();

            if (userNameLogin == userName && passwordLogin == password)
            {
                Console.WriteLine("Welcome {0}", userName);
            }
            else
            {
                Console.WriteLine("Incorrect username or password has been entered.");
            }
        }
    }
}