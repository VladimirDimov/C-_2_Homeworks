/*
Problem 7. Replace sub-string
=============================
Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
================================================================================================================
*/

using System;
using System.Collections.Generic;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        const string start = "start";
        const string finish = "finish";
        string filePath;
        string currentLine = null;
        List<string> allLines = new List<string>();

        Console.WriteLine("Enter input file path:");
        filePath = Console.ReadLine();
        StreamReader reader = new StreamReader(filePath);

        while ((currentLine = reader.ReadLine()) != null)
        {
            currentLine = currentLine.Replace(start, finish);
            allLines.Add(currentLine);
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(filePath, false);

       foreach (var line in allLines)
       {
           writer.WriteLine(line);
       }
        writer.Close();
    }
}
