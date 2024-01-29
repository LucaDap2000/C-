using System.Collections;
using System.Security.AccessControl;
namespace Array_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an array list with undefined amount of objects

            ArrayList myArrayList = new ArrayList();

            // Declaring an array list with a defined amount of objects

            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // Delete element with specific value from the array list

            myArrayList.Remove(13);
            myArrayList.Remove(13);

            // Delete element at specific index

            myArrayList.RemoveAt(0);

            // Count number of objects within the array list

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
