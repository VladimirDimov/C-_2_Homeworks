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
            inputTex = HideForbidenWord(inputTex, word);
        }

        Console.WriteLine(inputTex);
    }

    static string HideForbidenWord(string inputText, string forbidenWord)
    {
        StringBuilder text = new StringBuilder();
        text.Append(inputText);
        int index = 0;
        while (index >= 0)
        {
            index = text.ToString().IndexOf(forbidenWord, index);
            if (index < 0)
            {
                return text.ToString();
            }
            if (index == 0)
            {
                if (!char.IsLetter(text[index + forbidenWord.Length]))
                {
                    for (int i = index; i < index + forbidenWord.Length; i++)
                    {
                        text[i] = '*';
                    }
                }
            }
            else if (0<index && index < text.Length - forbidenWord.Length+1)
            {
                if (!char.IsLetter(text[index - 1]) && !char.IsLetter(text[index + forbidenWord.Length]))
                {
                    for (int i = index; i < index + forbidenWord.Length; i++)
                    {
                        text[i] = '*';
                    }
                }
            }
            else if (index == text.Length - forbidenWord.Length+1)
            {
                if (!char.IsLetter(text[index-1]))
                {
                    for (int i = index; i < index + forbidenWord.Length; i++)
                    {
                        text[i] = '*';
                    }
                }
            }
            index += forbidenWord.Length;
        }
        return text.ToString();
    }
}
