/*
Problem 3. Line numbers
=======================
Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
==============================================================================================
*/

using System;
using System.Text;
using System.IO;

class AddNumbers
{
    static void Main()
    {
        StringBuilder currentLineText = new StringBuilder();
        int lineCounter = 0;
        string readCurLine = null;

        Console.WriteLine("Enter a valid text file path:");
        string inputFilePath = Console.ReadLine();
        if (!File.Exists(inputFilePath))
        {
            throw new FileNotFoundException();
        }
        StreamReader reader = new StreamReader(inputFilePath);

        Console.WriteLine("Enter output file path:");
        StreamWriter writer = new StreamWriter(Console.ReadLine(), false);
        while ((readCurLine = reader.ReadLine()) != null)
        {
            lineCounter++;
            currentLineText.Append(lineCounter);
            currentLineText.Append(" - ");
            currentLineText.Append(readCurLine);
            writer.WriteLine(currentLineText.ToString());
            currentLineText.Clear();
        }
        reader.Close();
        writer.Close();
    }
}
