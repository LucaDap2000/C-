namespace Challenge_Solution___If
{
    internal class Program
    {

        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("--------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login succesful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username");
            }
        }
    }
}