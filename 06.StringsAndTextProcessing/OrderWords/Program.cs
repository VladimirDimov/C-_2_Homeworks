/*
    Problem 24. Order words
    =======================
    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
    =============================================================================================================
*/

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter some words.separated by spaces:");
        string[] words = Console.ReadLine().Split();
        Array.Sort(words);

        Console.WriteLine("Sorted:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
