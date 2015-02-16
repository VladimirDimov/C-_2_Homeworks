/*
Problem 4. Compare text files
=============================
Write a program that compares two text files line by line and prints the number of lines that are 
the same and the number of lines that are different.
Assume the files have equal number of lines.
=================================================================================================
*/

using System;
using System.Text;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFileLine = null;
        string secondFileLine = null;
        int samLinesCounter = 0;
        int differentLinesCounter = 0;

        Console.WriteLine("Enter first file path:");
        StreamReader firstFileReader = new StreamReader(Console.ReadLine());

        Console.WriteLine("Enter second file path:");
        StreamReader secondFileReader = new StreamReader(Console.ReadLine());

        while ((firstFileLine = firstFileReader.ReadLine()) != null && (secondFileLine = secondFileReader .ReadLine()) != null)
        {
            if (firstFileLine == secondFileLine)
            {
                samLinesCounter++;
            }
            else
            {
                differentLinesCounter++;
            }
        }
        Console.WriteLine("Same lines: {0}", samLinesCounter);
        Console.WriteLine("Differrent lines: {0}", differentLinesCounter);
    }
}
