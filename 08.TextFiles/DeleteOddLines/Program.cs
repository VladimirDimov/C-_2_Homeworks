/*
Problem 9. Delete odd lines
===========================
Write a program that deletes from given text file all odd lines.
The result should be in the same file
================================================================
*/

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        int counter = 0;
        List<string> allRows = new List<string>();
        string currentRow = null;
        string filePath;
        
        Console.WriteLine("Enter file path:");
        filePath = Console.ReadLine();
        StreamReader reader = new StreamReader(filePath);

        while ((currentRow = reader.ReadLine()) != null)
        {
            counter++;
            if (counter % 2 == 0)
            {
                allRows.Add(currentRow);
            }
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(filePath);
        foreach (var row  in allRows)
        {
            writer.WriteLine(row);
        }
        writer.Close();
    }
}
