namespace MainArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The args array cannot be null so, it's safe to access the Length property without null checking
            // We can therefore check the length of the array if it's zero it means no arguments were provided to the application

            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ;) please provide arguments next time. Pass help if you need more details");
                // Pause the application so it doesn't quit after printing our error message
                Console.ReadKey();
                // Quit the application entirely as we can't proceed further since the arguments are empty
                return;
            }

            // Check if the first command we got is help
            if (args[0] == "help")
            {
                // Display manual
                Console.WriteLine("*************** Instructions:");
                Console.WriteLine("* Use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("***************");

                // Pause
                Console.ReadKey(true);
                return;
            }

            // Check the length of args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // Pause
                Console.ReadKey();
                // Quit the app
                return;
            }

            // In C# 6 and earlier, you must declare a variable in a separate statement before you pass it
            // as an out argument
            // if the parsing operation fails the variable passed out will have its default value
            // if it was a value type or null if it's a reference type
            // it is more logical to declare and pass the variable in the same line

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // Pause
                Console.ReadKey();
                // Quit the app
                return;
            }

            // A variable to store the results
            float result;

            switch (args[0])
            {
                // Case 1 'add' the two numbers and print the value
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}", num1, num2, result);

                    break;
                // Case 2 'sub' subtract the two numbers and print the value
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sub of {num1} and {num2} is {result}", num1, num2, result);

                    break;
                // Default case, here we can handle wrong commands by printing an error message
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");

                    break;
            }

            Console.ReadKey();
        }
    }
}
