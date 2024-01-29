namespace Enhanced_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condition ? first_expression : second_expression;
            // Condition has to be either true or false
            // The conditional operator is right - associative
            // The expression a ? b : c? d : e,
            // not as (a? b : c) d : e
            // The conditional operator cannot be overloaded

            // In Celsius
            int temperature = -5;
            string stateOfMatter;
            
            if(temperature < 0)
            {
                stateOfMatter = "Solid";
            }

            else if(temperature > 100)
            {
                stateOfMatter = "Gas";
            }
            else
            {
                stateOfMatter = "Liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 100;

            // In short:
            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

            // Challenge - add the gas state of matter
            
            temperature += 100;

            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();
        }
    }
}