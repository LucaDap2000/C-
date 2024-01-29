namespace Multi_Dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // Two dimensional array

            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },  // Row 0
                { 4, 5, 6 },  // Row 1
                { 7, 8, 9 },  // Row 2
            };

            Console.WriteLine("The central value is {0}", array2D[1,1]);
            Console.WriteLine("Row 2, index 0 has a value of {0}", array2D[2,0]);

            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001" },
                    { "010", "011" },
                    { "Hi there", "What's up?" }
                },
                {
                    { "100", "101" },
                    { "110", "111" },
                    { "Another one", "Last entry" }
                }
            };

            // Alternative way of initialising a multidimensional array
            string[,] array2DString = new string[3, 2] 
            { 
                { "one", "two" }, 
                { "three", "four" }, 
                { "five", "six" } 
            };

            array2DString[1, 1] = "Chicken";

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", array3D[1,2,1]);
            Console.WriteLine("The value is {0}", array2DString[1,1]);
            Console.WriteLine("The number of dimensions of array2DString is {0}", dimensions);
            Console.ReadKey();
        }
    }
}
