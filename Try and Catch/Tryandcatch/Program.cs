namespace Tryandcatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please enter a number: ");
            // string userInput = Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            string inputNumber = Console.ReadLine();
            int inputNumberAsInt = Int32.Parse(inputNumber);
            int divisionResult;

            try
            {
                // int userInputAsInt = Int32.Parse(userInput);
                divisionResult = inputNumberAsInt / 0;
                Console.WriteLine(divisionResult);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero error");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time: ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for a 32 bit integer: ");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception, the value is empty (null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
        }
    }
}