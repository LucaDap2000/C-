using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clean_Code___Exception_Handling
{
    internal class Program
    {

        // We should always try and catch the error and return a precise description of what has gone wrong
        // so that whoever sees the error can clearly diagnose the issue and proceed

        // Example:

        static void ReadFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // File not found
            // Unauthorised access
            // Any other exception
        }
    }
}
