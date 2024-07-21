using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Check if the correct number of arguments are provided
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Program.exe <inputFilePath> <outputFilePath>");
                return;
            }

            string inputFilePath = args[0];
            string outputFilePath = args[1];

            try
            {
                // Open the input text file using a stream reader (using dynamic inputFilePath)
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    // Open the output text file using a stream writer (using dynamic outputFilePath)
                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        int lineNumber = 1;
                        string line;

                        // Read each line from the input file
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Write the line number and the line content to the output file
                            sw.WriteLine($"{lineNumber:D4}: {line}");
                            lineNumber++;
                        }
                    }
                }

                Console.WriteLine($"Line numbers added and saved to: {outputFilePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
