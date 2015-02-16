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

class CountWords
{
    static void Main()
    {
        string filesDirectory;
        List<string> words = new List<string>();
        List<string> test = new List<string>();
        Dictionary<string, int> result = new Dictionary<string, int>();
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
            while ((currentWord = reader.ReadLine()) != null)
            {
                test.Add(currentWord);
            }
            reader.Dispose();

            //Count words
            foreach (var word in test)
            {
                if (words.Contains(word))
                {
                    if (result.ContainsKey(word))
                    {
                        result[word]++;
                    }
                    else
                    {
                        result.Add(word, 1);
                    }
                }
            }

            //Write result to output file;
            writer = new StreamWriter(filesDirectory + @"\result.txt", false);
            foreach (var word in result.Keys)
            {
                writer.WriteLine("Word {0} contains {1} times.", word, result[word]);
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
