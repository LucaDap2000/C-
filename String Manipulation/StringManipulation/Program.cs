namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define some variables
            int age = 23;
            string name = "Luca";
            double myDouble = 1.75;
            string job = "Consulting Engineer";


            // 1. String concatination
            Console.WriteLine("String Concatination");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            // 2. String formatting
            // String formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old, and {2}m tall. I'm also a {3}", name, age, myDouble, job);

            // 3. String interpolation
            // String interpolation uses $ at the start which will allow us to write our variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            // 4. Verbatim strings
            // Verbatim strings start with @ and tells the compiler to take the string literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet,

Hello my name is Luca.

I am 23 years old.

I am 1.75m tall.

I am a Consulting Engineer.");

            // Instead of using \\ to write file paths we can use verbatim strings to make it easier
            // If you remove the @ you will get an error becayse \U, \A and \D are not valid escape characters for example
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Super CoolDog.png");

            // With verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muhahaha \n you have no powers here!.");
            Console.WriteLine("Muhahaha \n you have powers here!.");
        }
    }
}