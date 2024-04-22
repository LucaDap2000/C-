namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14159;

            bool? boolVal = new bool?();

            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("The nullable boolean value is {0}", boolVal);

            bool? isMale = null;

            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender found");
            }

            double? num5 = 13.1;
            double? num6 = null;
            double num7;

            if (num5 == null)
            {
                num7 = 0.0;
            }
            else
            {
                num7 = (double)num5;
            }

            Console.WriteLine("Value of num7 is {0}", num7);

            // Shorter: The null coalescing operator ??
            num7 = num5 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);
            num7 = num6 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);
        }
    }
}
