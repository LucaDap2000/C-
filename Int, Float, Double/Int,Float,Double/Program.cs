namespace Int_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring multiple variables at once
            int num3, num4, num5;
            // Declaring a variable
            int num1;
            // Assigning a value to a variable
            num1 = 13;

            // Declaring and initializing a variable in one line
            int num2 = 23;
            long myLongNum = 2177836391010334843;
            num2 = 100;
            // Using concatination (concatination = adding together strings and/or numbers)
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);

            Console.Read();
        }
    }
}