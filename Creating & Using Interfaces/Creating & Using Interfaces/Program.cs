namespace Creating___Using_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of type Chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // Creating a new object of type Car
            Car damagedCar = new Car(80f, "Blue");

            // Add the two chairs to the IDestroyable list of the car
            // so that when we destroy the car the destroyable objects
            // that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // Destroy the car
            damagedCar.Destroy();
        }
    }
}
