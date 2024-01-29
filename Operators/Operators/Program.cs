namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny); // An ! negates the boolean so it is opposite to how it was defined

            // Increment operators
            int num = 0;
            num++; // ++ will increment
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); // post increment
            Console.WriteLine("num is {0}", ++num); // pre increment

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--); // post decrement
            Console.WriteLine("num is {0}", --num); // pre decrement

            int result;

            result = num1 + num2;
            Console.WriteLine("Result of num1 + num2 is: {0}", result);
            result = num1 - num2;
            Console.WriteLine("Result of num1 - num2 is: {0}", result);
            result = num1 / num2;
            Console.WriteLine("Result of num1 / num2 is: {0}", result);
            result = num1 * num2;
            Console.WriteLine("Result of num1 * num2 is: {0}", result);
            result = num1 % num2;
            Console.WriteLine("Result of num1 % num2 is: {0}", result);

            // Relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 is: {0}", isLower);

            // Equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is: {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is: {0}", isEqual);

            // Conditional operators
            bool isLowerAndSunny;
            // The && is like the AND condition
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower && isSunny is: {0}", isLowerAndSunny);

            // The || is like the OR condition
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result of isLower || isSunny is: {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}