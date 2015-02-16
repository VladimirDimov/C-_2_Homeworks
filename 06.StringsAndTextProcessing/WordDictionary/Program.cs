/*
Problem 14. Word dictionary
===========================
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
==========================================================================================
Sample dictionary:

input	    |output
------------|---------------------------------------------
.NET	    |platform for applications from Microsoft
            |CLR	managed execution environment for .NET
----------------------------------------------------------
namespace	|hierarchical organization of classes
*/          

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, String> wordDictionary = new Dictionary<string, string>();
        string inputWord = null;

        wordDictionary.Add(".NET", "platform for applications from Microsoft");
        wordDictionary.Add("CLR", "managed execution environment for .NET");
        wordDictionary.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("Enter aword to translate:");
        inputWord = Console.ReadLine();
        if (wordDictionary.ContainsKey(inputWord))
        {
            Console.WriteLine("Translation: {0}", wordDictionary[inputWord]);
        }
        else
        {
            Console.WriteLine("Word not found!");
            Console.WriteLine("Try \".NET\", \"CLR\" or \"namespace\"");
        }
    }
}
