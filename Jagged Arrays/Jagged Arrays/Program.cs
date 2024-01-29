namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Index                      0    1    2    3 
            // Normal array of type int: [15],[21],[23],[13]
            // Index                        0                       1                     2
            // Jagged array of type int: [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]


            // Declare a jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] {2,3,5,7,11};
            jaggedArray[1] = new int[] {1,2,3};
            jaggedArray[2] = new int[] {13,21};

            // Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2,3,5,7,11},
                new int[] {1,2,3},
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element at position {0}", i);
                
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} is our jagged array at position [i][j]", jaggedArray2[i][j]);
                }
            }

            Console.ReadKey();

        }
    }
}
