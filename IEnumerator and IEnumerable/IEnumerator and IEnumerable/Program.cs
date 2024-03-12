using System;
using System.Collections;
using System.Collections.Generic;
namespace IEnumerator_and_IEnumerable
{
    internal class Program
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non-generic collections

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface
        /// GetEnumerator(), which returns an IEnumerator<T> object
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a current property that points at the object we are currently at in the collection
        /// </summary>
        /// <param name="args"></param>

        /// <summary>
        /// When you should use IEnumerable interfaces:
        /// Your collection represents a massive database table
        /// You don't want to copy the entire thing into memory and cause performance issues in your application
        /// When you should not use IEnumerable interfaces:
        /// You need the results right away and are possibly editing the objects later on
        /// In this case it is better to use an array or a list
        /// </summary>

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }

    class Dog
    {
        // Name of the dog
        public string Name { get; set; }

        // Is this a naughty dog?
        public bool IsNaughtyDog { get; set; }

        // Simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // This method will print how many treats the dog received
        public void GiveTreat (int numberofTreats)
        {
            // Print a message containing the number of treats and name the dog
            Console.WriteLine("Dog: {0} said wooooof! {1} times!", Name, numberofTreats);
        }
    }

    // A class named DogShelter this class contains a generic collection of type Dog
    // Objects of this class can't be used inside a for each loop because it lacks an implementation of IEnumerable interface

    class DogShelter : IEnumerable<Dog>
    {
        // List of type <Dog>
        public List<Dog> dogs;
        // This constructor will initialise the dogs list with some values

        public DogShelter()
        {
            // Initialise the dogs list using the collection-initialiser
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
