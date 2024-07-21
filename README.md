Homework #3 Part2

2. Exercise that uses StreamReader, StreamWriter, Command-Line Arguments. Write a program that reads a text file (C# source code for example), inserts line numbers, instead of displaying to the Console window,  writes out to a text file. Your program runs on the command line like the following:
      Program.exe  Hello.cs  Hello2.cs

Here is the Link for part2. https://github.com/khmerChaiTea/CSC205HW3_Part2/tree/master/Program

To copy the read file to another file,
Step 1, we need a file to read. Such as Hello.cs or words.txt. Make sure to put it in the directory of the Program.exe (or What name you gave it with .exe). It is located in the \Program\bin\Debug.

Step 2, used the Program that was made to read and write text file (code below).

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

Step 3, build Program.exe by compiling the Program; Build --> Build Solution (CTRL + SHIFT + B) or "dotnet build" if not using Visual Studio

Step 4, run the Program by open Command Prompt (Window + R, type 'cmd' then click ok)
using 'cd' (change directory with 'dir') navigate to the 'Program.exe' location

Step 5, when reach the end, type "Program.exe Hello.cs Hello2.cs" (with the Program.exe, Read Hello.cs and copy it to Hello2.cs)
