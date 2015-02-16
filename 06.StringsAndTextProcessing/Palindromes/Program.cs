/*
Problem 20. Palindromes
=======================
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
=======================================================================================
*/

using System;

class Palindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some text");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word  in words)
        {
            if (isPalindrome(word))
            {
                Console.WriteLine("Palindrome: {0}" , word);
            }
        }

    }

    static bool isPalindrome(string word)
    {
        for (int i = 0; i < word.Length/2; i++)
        {
            if (word[i] != word[word.Length-1-i])
            {
                return false;
            }
        }
        return true;
    }
}
