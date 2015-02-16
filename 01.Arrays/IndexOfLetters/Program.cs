//  Write a program that creates an array containing all letters from the alphabet (A-Z).
//  Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char['z' - 'a' + 1];
        string word = null;

        for (char i = 'a'; i <= 'z'; i++)
        {
            letters[i - 'a'] = i;
        }

        Console.WriteLine("Type \"exit\" to end program.");
        while (true)
        {
            word = Console.ReadLine();
            if (word == "exit")
            {
                return;
            }
            Console.Write("\"{0}\" => ", word);
            foreach (var item in word)
            {
                Console.Write("{0} ", Array.BinarySearch(letters, item));
            }
            Console.WriteLine();
        }
    }
}
