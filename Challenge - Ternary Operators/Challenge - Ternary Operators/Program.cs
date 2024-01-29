namespace Challenge___Ternary_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckTemperature();
            Console.Read();
        }

        public static void CheckTemperature()
        {
            string inputTemperature;
            string temperatureAdvice;

                try
                {
                    Console.WriteLine("Please input a temperature here: ");
                    inputTemperature = Console.ReadLine();
                    int inputTemperatureAsInt = Int32.Parse(inputTemperature);
                    temperatureAdvice = inputTemperatureAsInt <= 15 ? "It is too cold here" :
                    inputTemperatureAsInt >= 16 && inputTemperatureAsInt <= 28 ? "It is ok" :
                    inputTemperatureAsInt > 28 ? "It is hot here" : "It is ok";
                    Console.WriteLine(temperatureAdvice);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Not a valid temperature");
                }
        }
    }
}