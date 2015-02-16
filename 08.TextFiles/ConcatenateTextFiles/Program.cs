/*
Problem 2. Concatenate text files
=================================
Write a program that concatenates two text files into another text file.
========================================================================
*/

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter first file path:");
            StreamReader firstFile = new StreamReader(Console.ReadLine());

            Console.WriteLine("Enter second file path:");
            StreamReader secondFile = new StreamReader(Console.ReadLine());

            Console.WriteLine("Enter output file path:");
            StreamWriter concatFile = new StreamWriter(Console.ReadLine());
            //concatenate

            concatFile.WriteLine(firstFile.ReadToEnd());
            concatFile.WriteLine(secondFile.ReadToEnd());

            firstFile.Close();
            secondFile.Close();
            concatFile.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
