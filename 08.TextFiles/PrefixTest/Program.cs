/*
Problem 11. Prefix "test"
=========================
Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
========================================================================================
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        string filePath;
        string pattern = @"\btest\w+\b";
        string text;

        //Console.WriteLine("Enter file path:");
        //filePath = Console.ReadLine();
        filePath = "file.txt";

        StreamReader reader = new StreamReader(filePath);
        text = reader.ReadToEnd();
        reader.Close();

        text = Regex.Replace(text, pattern, "");

        StreamWriter writer = new StreamWriter(filePath, false);
        writer.Write(text);
        writer.Close();
    }
}
