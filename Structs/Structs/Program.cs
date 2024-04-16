namespace Structs
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine("Game 1 is called: {0}", name);
            Console.WriteLine("Game 1 was developed by: {0}", developer);
            Console.WriteLine("Game 1 is rated: {0}", rating);
            Console.WriteLine("Game 1 will be released on: {0}", releaseDate);
        }

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01/07/16";

            game1.Display();

            Console.WriteLine("Game 1 is called: {0}", game1.name);
            Console.WriteLine("Game 1 was developed by: {0}", game1.developer);
            Console.WriteLine("Game 1 is rated: {0}", game1.rating);
            Console.WriteLine("Game 1 will be released on: {0}", game1.releaseDate);
        }
    }
}
