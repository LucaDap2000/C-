namespace Challenge_If_2___Solution
{
    internal class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Luca";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michael");
            CheckHighScore(350, "Luca");

            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highScore + " and held by " + highScorePlayer);
            }
        }
    }
}