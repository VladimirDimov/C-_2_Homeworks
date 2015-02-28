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
            //StreamReader fileReader = new StreamReader(Console.ReadLine());
            StreamReader fileReader = new StreamReader(@"Oddlines.txt");

            using (fileReader)
            {
                do
                {
                    lineNumber++;
                    currentLine = fileReader.ReadLine();
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(currentLine);
                    }
                } while (currentLine != null);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
