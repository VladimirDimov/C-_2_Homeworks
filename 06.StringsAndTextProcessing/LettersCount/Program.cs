/*
Problem 21. Letters count
=========================
Write a program that reads a string from the console and prints all different letters in the 
string along with information how many times each letter is found.
============================================================================================
*/

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string text;
        Dictionary<char, int> letters = new Dictionary<char, int>();

        Console.WriteLine("Enter some text:");
        text = Console.ReadLine();
        foreach (var symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                if (letters.ContainsKey(symbol))
                {
                    letters[symbol]++;
                }
                else
                {
                    letters.Add(symbol, 1);
                }
            }
        }
        foreach (var letter in letters.Keys)
        {
            Console.WriteLine("Letter \"{0}\" : {1} times", letter, letters[letter]);
        }
    }
}
