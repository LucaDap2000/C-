using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating___Using_Interfaces
{
    // Child class Car that inherits from Vehicle
    internal class Car : Vehicle, IDestroyable
    {
        // Implementing the interfaces property (manually removing the error)
        public string DestructionSound { get; set; }

        /* Creating a new property to store the destroyable objects nearby
         * when a car gets destroyed it should also destroy the nearby object
         * this list is of type IDestroyable which means it can store any object
         * that implements this interface and we can only access the properties
         * and methods in this interface
        */
        public List<IDestroyable> DestroyablesNearby;

        // Simple constructor
        public Car(float speed, string colour) : base(speed, colour)
        {
            // Here we have inherited the simple constructor from the Vehicle
            // class using the base keyword but the method used in the Chair
            // class is also valid

            // Initialise the interfaces property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";

            // Initialise the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        // Implementing the interfaces method
        public void Destroy()
        {
            // When a car gets destroyed we should play the destruction sound
            // and create a fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            // Go through each destroyable object nearby and call its destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

        // Auto-generated error exception from 'show potential fixes'

        string IDestroyable.DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IDestroyable.Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
