/*
    Problem 23. Series of letters
    =============================
    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
    ================================================================================================================================
    Example:
    --------------------------------
    input	                    output
    aaaaabbbbbcdddeeeedssaa	    abcdedsa
*/

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();
        char currentChar;
        char prevChar = ' ';

        Console.WriteLine("Enter some string:");
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            currentChar = text[i];
            if (currentChar != prevChar)
            {
                result.Append(currentChar);
            }
            prevChar = currentChar;
        }
        Console.WriteLine("Result:\n{0}", result);
    }
}
