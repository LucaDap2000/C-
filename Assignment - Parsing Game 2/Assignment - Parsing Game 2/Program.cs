using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Schema;
namespace Assignment___Parsing_Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);

            string text = System.IO.File.ReadAllText(@"C:\Users\Luca D'Aprano\OneDrive\Documents\input2.txt");

            MatchCollection matchCollection = regex.Matches(text);

            string[] matchCollectionString = new string[matchCollection.Count];

            int[] collectionAsIntArray = new int[matchCollection.Count];

            for (int i = 0; i < matchCollectionString.Length; i++) 
            {
                matchCollectionString[i] = matchCollection[i].Groups[0].Value;
                collectionAsIntArray[i] = int.Parse(matchCollectionString[i]);
            }

            foreach (int i in collectionAsIntArray)
            {
                char intChar = (char)i;
                Console.WriteLine(intChar);
            }

            /*
            Console.WriteLine("{0} hits found:\n{1}", matchCollection.Count, text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
            */

            Console.Read();
        }
    }
}
