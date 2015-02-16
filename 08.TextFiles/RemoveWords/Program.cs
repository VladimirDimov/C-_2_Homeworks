/*
Problem 12. Remove words
========================
Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
==========================================================================================
text:
--------
HTML Color Codes website provides free color tools for finding HTML colors for your website. Great tools HTML color chart and HTML color picker will make this simple as a walk in the park.
To quickly start using HTML colors in your website take a look at How to use HTML color codes?. If you wish to learn what this combination of characters in HTML Color Codes actually means than take a look at section HTML Color Codes Theory.
Web safe colors is the list of colors that look the same on all operating systems. And if you have color blindness then check out HTML Color Names to overcome that problem.
Make sure you checkout my blog with tutorials and lists of the best freeware software and online services for web developers.

list:
--------
color
HTML
tool
list
*/
//C:\Users\vladko\Desktop
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        List<string> listedWords = new List<string>();
        StreamReader reader;
        StreamWriter writer;
        string textFilePath;
        string listedWordsPath;
        string currentWord;
        string text;

        try
        {
            //Read text
            Console.WriteLine("Enter text file path:");
            textFilePath = Console.ReadLine();
            if (File.Exists(textFilePath) == false)
            {
                throw new FileNotFoundException("The requested file was not found!");
            }
            reader = new StreamReader(textFilePath);
            text = reader.ReadToEnd();
            reader.Dispose();

            //Read list of words
            Console.WriteLine("Enter list of words file path:");
            listedWordsPath = Console.ReadLine();
            if (File.Exists(listedWordsPath) == false)
            {
                throw new FileNotFoundException("The requested file was not found!");
            }
            reader = new StreamReader(listedWordsPath);
            while ((currentWord = reader.ReadLine()) != null)
            {
                listedWords.Add(currentWord);
            }
            reader.Dispose();

            //delete words in text
            foreach (var word in listedWords)
            {
                string pattern = @"\b" + word + @"\b";
                text = Regex.Replace(text, pattern, "", RegexOptions.IgnoreCase);
            }

            //Write to file the new text
            writer = new StreamWriter(textFilePath, false);
            writer.Write(text);
            writer.Dispose();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
