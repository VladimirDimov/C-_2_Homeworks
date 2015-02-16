/*
    Problem 22. Words count
    =======================
    Write a program that reads a string from the console and lists all different words in
    the string along with information how many times each word is found.
    =====================================================================================
*/

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        char[] splitters = {' ', ',', '.', '!', '?', '(', ')', ':', ';'};
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        string[] words = text.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (wordsDictionary.ContainsKey(word))
            {
                wordsDictionary[word]++;
            }
            else
            {
                wordsDictionary.Add(word, 1);
            }
        }
        foreach (var word in wordsDictionary.Keys)
        {
            Console.WriteLine("Word \"{0}\": {1} times", word, wordsDictionary[word]);
        }
    }
}
