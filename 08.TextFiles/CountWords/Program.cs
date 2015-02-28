/*
Problem 13. Count words
=======================
Write a program that reads a list of words from the file words.txt and finds how many times 
each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the 
number of their occurrences in descending order.
Handle all possible exceptions in your methods.
============================================================================================
*/
//C:\Users\vladko\Desktop\new
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        string filesDirectory;
        List<string> words = new List<string>();
        StringBuilder builder = new StringBuilder();
        StreamReader reader;
        StreamWriter writer;

        try
        {
            Console.WriteLine("Enter directory with requested files:");
            filesDirectory = Console.ReadLine();
            if (Directory.Exists(filesDirectory) == false)
            {
                throw new DirectoryNotFoundException("Invalid directory");
            }

            //Read words
            string currentWord;
            if (!File.Exists(filesDirectory + @"\words.txt"))
            {
                throw new FileNotFoundException("File not found!");
            }
            reader = new StreamReader(filesDirectory + @"\words.txt");
            while ((currentWord = reader.ReadLine()) != null)
            {
                words.Add(currentWord);
            }
            reader.Dispose();

            //read test
            if (!File.Exists(filesDirectory + @"\test.txt"))
            {
                throw new FileNotFoundException("File not found!");
            }
            reader = new StreamReader(filesDirectory + @"\test.txt");
            builder.Append(reader.ReadToEnd());
            reader.Dispose();

            //Write result to output file;
            writer = new StreamWriter(filesDirectory + @"\result.txt", false);


            //Count words
            foreach (var word in words)
            {
                string pattern = @"\b" + word + @"\b";
                int counter = Regex.Matches(builder.ToString(), pattern).Count;
                writer.WriteLine("Word {0} contains {1} times.", word, counter);
            }
            writer.Dispose();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
