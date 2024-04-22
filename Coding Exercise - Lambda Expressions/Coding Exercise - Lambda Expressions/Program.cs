namespace Coding_Exercise___Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
                {"+", Plus},
                {"-", Minus},
                {"/", Divide},
                {"*", Multiply}
        };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }
    }
}
