namespace Multicast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an audio system
            AudioSystem audioSystem = new AudioSystem();
            // Create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();
            // Create two players and give them ID's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running... Press any key to end the game");

            // Pause
            Console.Read();

            GameEventManager.TriggerGameOver();
        }
    }
}
