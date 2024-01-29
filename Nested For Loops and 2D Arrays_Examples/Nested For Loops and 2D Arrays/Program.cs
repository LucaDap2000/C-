namespace Nested_For_Loops_and_2D_Arrays
{
    internal class Program
    {

        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };

        static void Main(string[] args)
        {
            // With nested for loop

            Console.WriteLine("\n This is our 2D array printed using nested for loop");

            // Outer for loop '.GetLength(0) will return the zeroth dimension
            // zeroth dimension = number of rows

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                // Inner for loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(matrix[i,j]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

            // With foreach loop

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                // This loop goes through each element in the diagonal

                Console.WriteLine(matrix[i, i]);

            }

            // My solution

            Console.WriteLine("Opposing diagonal matrix elements appear now");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j == 2)
                        Console.WriteLine(matrix[i,j]);
                }
            }

            // Denis' solution

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]);
            }
        }
    }
}
