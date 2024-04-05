namespace Polymorphic_Parameters
{
    internal class Program
    {
        // Create a base class Car with two properties HP and Colour
        // Create a constructor setting those two properties
        // Create a method called ShowDetails() which shows the HP and Colour of the car on the console
        // Create a Repair method which writes "Car was repaired!" onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an additional property
        // called model. Also a private member called Brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            // A car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi, BMW, Porsche
            // can all be used where ever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class

            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Red", "M3")
            };

            // Polymorphism at work #2: The virtual method Repair is 
            // invoked on each of the derived classes, not the base class
            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "Black", "Z3");
            Car audiA3 = new Audi(100, "Green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "White", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Red", "M3 Sport");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}
