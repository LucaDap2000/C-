namespace Challenge___Jagged_Arrays
{
    internal class Program
    {

        // Create a jagged array which contains 3 "family arrays" in which two family members should be stored
        // Introduce family members from different families to eachother via console

        static void Main(string[] args)
        {
            string[][] jaggedArrays = new string[3][];
            {
                jaggedArrays[0] = new string[2];
                jaggedArrays[1] = new string[2];
                jaggedArrays[2] = new string[2];

                jaggedArrays[0] = new string[] {"Jane","Giuliano"};
                jaggedArrays[1] = new string[] {"Giovanni","Alessandro"};
                jaggedArrays[2] = new string[] {"Alessio","Enzo"};

                foreach (string i in jaggedArrays[0])
                {
                    Console.WriteLine("Hello! {0}, {1}, {2} and {3} My name is {4}, nice to meet you :)", jaggedArrays[1][0], jaggedArrays[1][1], jaggedArrays[2][0], jaggedArrays[2][1], i);
                }

                foreach (string i in jaggedArrays[1])
                {
                    Console.WriteLine("Hello! {0}, {1}, {2} and {3} My name is {4}, nice to meet you :)", jaggedArrays[0][0], jaggedArrays[0][1], jaggedArrays[2][0], jaggedArrays[2][1], i);
                }

                foreach (string i in jaggedArrays[2])
                {
                    Console.WriteLine("Hello! {0}, {1}, {2} and {3} My name is {4}, nice to meet you :)", jaggedArrays[0][0], jaggedArrays[0][1], jaggedArrays[1][0], jaggedArrays[1][1], i);
                }

                Console.Read();

            }
        }
    }
}
