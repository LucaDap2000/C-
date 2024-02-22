namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the Birthday wishes", true, "Luca D'Aprano");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Luca D'Aprano", 
                "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
