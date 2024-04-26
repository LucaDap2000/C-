using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    // RenderingEngine Class
    internal class RenderingEngine
    {
        // Simple constructor
        public RenderingEngine() 
        {
            // Subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game we want to enable rendering engine and
        // start drawing the visuals
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing visuals...");
        }

        // When the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering engine stopped");
        }
    }
}
