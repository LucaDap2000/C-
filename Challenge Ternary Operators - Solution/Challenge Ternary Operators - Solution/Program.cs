namespace Challenge_Ternary_Operators___Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // Takes input from console
            Console.WriteLine("Enter the current temperature: ");
            inputValue = Console.ReadLine();

            // Validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if(validInteger)
            {   // Condition ? iftrue : iffalse
                // If it is valid then it will check for the conditions using nested ternary operator here
                temperatureMessage = inputTemperature <= 15 ?
                // True
                "It is too cold here" :
                // False
                (inputTemperature >= 16 && inputTemperature <= 28) ?
                // True
                "It is ok" :
                // False
                inputTemperature > 28 ? 
                // True
                "It is hot here" : 
                // False
                "";
                Console.WriteLine(temperatureMessage);
                
            }
            else
            {
                // In case input value is not a valid temperature
                Console.WriteLine("Not a valid temperature");
            }
            Console.ReadKey();
        }
    }
}