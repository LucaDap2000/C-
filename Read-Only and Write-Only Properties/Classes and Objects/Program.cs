using System.Threading.Channels;

namespace Classes_and_Objects
{

    // A class in C# (and most other object-oriented programming languages)
    // is a blueprint for creating objects
    // It defines a set of properties (data attributes)
    // and methods (functions) that an object of that class will have.

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.setName("Luca's Car");
            Console.WriteLine(myCar.GetName());
            Console.WriteLine(myCar.GetHP());
            myCar.Details();
            Car audi = new Car("Audi A4", 200, "blue");
            audi.Drive();
            audi.Details();
            Car bmw = new Car("BMW M5", 350, "red");
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("car drives indefinitely");
            }
        }
    }
}