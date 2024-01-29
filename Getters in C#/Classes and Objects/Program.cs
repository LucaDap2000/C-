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
            Console.WriteLine(myCar.Name);
        }
    }
}