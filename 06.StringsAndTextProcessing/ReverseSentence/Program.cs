/*
Problem 13. Reverse sentence
============================
Write a program that reverses the words in given sentence.
==========================================================
Example:

input	output
C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        StringBuilder currentWord = new StringBuilder();
        StringBuilder currentSigns = new StringBuilder();
        Stack<string> reversedWords = new Stack<string>();
        Queue<string> punctuationSigns = new Queue<string>();
        StringBuilder reversedSentence = new StringBuilder();
        char[] signs = { ' ', '.', '?', '!', '-', ',', (char)59, (char)58 };

        Console.WriteLine("Enter some sentence:");
        string sentence = Console.ReadLine();

        foreach (var symbol in sentence)
        {
            if (!signs.Contains(symbol))
            {
                currentWord.Append(symbol);
                if (currentSigns.Length > 0)
                {
                    punctuationSigns.Enqueue(currentSigns.ToString());
                    currentSigns.Clear();
                }
            }
            else
            {
                currentSigns.Append(symbol);
                if (currentWord.Length > 0)
                {
                    reversedWords.Push(currentWord.ToString());
                    currentWord.Clear();
                }
            }
        }
        if (currentSigns.Length > 0)
        {
            punctuationSigns.Enqueue(currentSigns.ToString());
            currentSigns.Clear();
        }
        if (currentWord.Length > 0)
        {
            reversedWords.Push(currentWord.ToString());
            currentWord.Clear();
        }


        while (reversedWords.Count != 0 || punctuationSigns.Count != 0)
        {
            if (reversedWords.Count != 0)
            {
                reversedSentence.Append(reversedWords.Pop());
            }
            if (punctuationSigns.Count != 0)
            {
                reversedSentence.Append(punctuationSigns.Dequeue());
            }
        }
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversedSentence.ToString());
    }
}
