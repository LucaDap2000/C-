namespace Coding_Exercise___Delegates
{
    internal class Program
    {
        public delegate float OperationDelegate(float a, float b);
        static void Main(string[] args)
        {

        }
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static float ApplyOperation(float a, float b, OperationDelegate oper)
        {
            float result;
            result = oper(a, b);

            return result;
        }
    }
}
