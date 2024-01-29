namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the temperature here: ");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }

            else

                numTemp = 0;
                Console.WriteLine("Invalid input so, Temperature = 0");

            if (numTemp < 21)

            {
                Console.WriteLine("Wear a coat");
            }

            else if (numTemp == 21)

            {
                Console.WriteLine("Jeans and a polo shirt is fine");
            }

            else if (numTemp > 30)

            {
                Console.WriteLine("It's very hot");
            }

            else

            {
                Console.WriteLine("Wear some shorts");
            }

            Console.Read();

        }
    }
}