namespace Challenge___if2
{
    internal class Program
    {
        static int highScore = 100;
        static string highScorePlayer = "Luca";

        static void Main(string[] args)
        {
            Player_Score(0, "");
            Console.Read();
        }

        public static void Player_Score(int score, string playerName)
        {
            Console.WriteLine("Please input your score here: ");
            string scoreAsString = Console.ReadLine();
            score = Int32.Parse(scoreAsString);
            Console.WriteLine("Please input your Player name here: ");
            playerName = Console.ReadLine();

            if(score > highScore)
            {
                Console.WriteLine("New highscore is {0}", score);
                Console.WriteLine("New highscore holder is {0}", playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of {0} could not be broken and is still held by {1}", highScore, highScorePlayer);
            }
        }
    }
}