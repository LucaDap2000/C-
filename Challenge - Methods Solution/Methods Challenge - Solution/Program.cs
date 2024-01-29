using System.Globalization;

namespace Methods_Challenge___Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Michael";
            string friend3 = "Wlad";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
        }

    }

}