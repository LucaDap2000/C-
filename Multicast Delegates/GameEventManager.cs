using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    internal class GameEventManager
    {
        // A new delegate type called GameEvent
        public delegate void GameEvent();

        // Create two delegates variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        // A static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // Check if the OnGameStart event is not empty, meaning that other methods already subscribed to it

            if (OnGameStart != null)
            {
                // Print a simple message
                Console.WriteLine("The game has started...");
                // Call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        // A static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            // Check if the OnGameOver event is not empty, meaning that other methods already subscribed to it

            if (OnGameOver != null)
            {
                // Print a sinmple message
                Console.WriteLine("The game is over...");
                // Call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
