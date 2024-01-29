using System.Diagnostics;

namespace Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;

            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }

            string[] bestFriendsnames = { "Sam", "Dan", "Matt", "Ronnie", "Joe" };

            foreach(string i in bestFriendsnames)
            {
                Console.WriteLine("Hi, {0} how are you?", i);
            }

            Console.ReadKey();

        }
    }
}
