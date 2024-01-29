namespace Challenge___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Peter";
            string friend2 = "Simon";
            string friend3 = "John";
            GreetFriend(friend1, friend2, friend3);
        }

        public static void GreetFriend(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("Hi {0}, my friend!", friend1);
            Console.WriteLine("Hi {0}, my friend!", friend2);
            Console.WriteLine("Hi {0}, my friend!", friend3);
        }

    }
}