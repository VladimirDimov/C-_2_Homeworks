/*
Problem 9. Forbidden words
==========================
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
==============================================================================================================================
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented 
as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is 
implemented as a dynamic language in ***.
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string inputTex = Console.ReadLine();

        Console.WriteLine("Enter some forbiden words separated by commas:");
        string[] forbidenWords = Console.ReadLine().Split(new char[]{',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in forbidenWords)
        {
            string pattern = @"\b" + word + @"\b";
            inputTex = Regex.Replace(inputTex, pattern, new string('*', word.Length));
        }
        Console.WriteLine(inputTex);
    }    
}
