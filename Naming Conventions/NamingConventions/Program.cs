namespace NamingConventions
{       // Class names like ClientActivity
    internal class Program
    {
        // Method name like CalculateValue
        // Method arguments like firstNumber
        static void Main(string[] args)
        {
            // Local variables like itemCount

            // use userControl instead of usrCtr in general

            // Don't use numbers at the start of variable names

            // Correct
            string myName;
            int lastNum;
            bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;
        }
    }
}