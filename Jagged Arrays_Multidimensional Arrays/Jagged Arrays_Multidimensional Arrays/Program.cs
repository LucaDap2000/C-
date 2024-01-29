namespace Jagged_Arrays_Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // We use jagged arrays when you need to create complex data structures with elements of different sizes

            // Declare and initialise a jagged array
            int[][] triangle = new int[][]
            {
                new int[] {1},
                new int[] {2,3},
                new int[] {4,5,6},
                new int[] {7,8,9,10},
            };

            // Use a "for each" loop to print each row of the triangle
            foreach (int[] row in triangle)
            {
                foreach (int number in row)
                {
                    Console.WriteLine(number);
                }
            }

            // We use multidimensional arrays when you need to perform mathematical operations on a grid of numbers of the same size

            // Declare and initialise a 2D array
            int[,] grid = new int[,]
            {
                {1,2},
                {3,4},
                {5,6},
                {7,8},
            };

            // Use a nested "for" loop to print each number in the grid
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i,j]);
                }
            }
        }
    }
}