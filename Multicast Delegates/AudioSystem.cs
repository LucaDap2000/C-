using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    // AudioSystem Class
    internal class AudioSystem
    {
        // Simple constructor
        public AudioSystem()
        {
            // Subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game we want to enable the audio system and start playing audio clips
        private void StartGame()
        {
            Console.WriteLine("Audio system started...");
            Console.WriteLine("Playing audio...");
        }

        // When the game is over we want to stop the audio system
        private void GameOver()
        {
            Console.WriteLine("Audio system stopped");
        }
    }
}
