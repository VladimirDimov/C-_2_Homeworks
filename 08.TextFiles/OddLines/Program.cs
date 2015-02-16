/*
Problem 1. Odd lines
====================
Write a program that reads a text file and prints on the console its odd lines.
===============================================================================
*/

//C:\Users\vladko\Desktop\textfile.txt
using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string currentLine = null;
        int lineNumber = 0;
        Console.WriteLine("Enter the file path:");
        try
        {
            StreamReader fileReader = new StreamReader(Console.ReadLine());

            using (fileReader)
            {
                lineNumber++;
                currentLine = fileReader.ReadLine();
                Console.WriteLine(currentLine);
                while (currentLine != null)
                {
                    lineNumber++;
                    currentLine = fileReader.ReadLine();
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(currentLine);
                    }
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
