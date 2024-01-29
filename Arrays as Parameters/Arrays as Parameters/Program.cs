namespace Arrays_as_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine("{0}", grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);

            #region CHALLENGE STARTS

            int[] happiness = new int[] { 10, 25, 50, 75, 100 };

            HappinessMethod(happiness);

            foreach (int happinessBoost in happiness)
            {
                Console.WriteLine("{0}", happinessBoost);
            }

            Console.Read();

        }

        static void HappinessMethod(int[] happinessArray)
        {
            for (int i = 0; i < happinessArray.Length; i++)
            {
                happinessArray[i] = happinessArray[i] + 2;
            }

        }

        #endregion CHALLENGE ENDS

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;

        }

        // CHALLENGE - Create an array of happiness in the main method and assign 5 values to it.
        // Create a method which has an array of type int as its parameter.
        // This method should increase the argument given by 2 for each entry.
        // Call this method in the main method and use "happiness" as the argument.
        // Create a foreach loop in the main method to write all values onto the console.
    }
}
