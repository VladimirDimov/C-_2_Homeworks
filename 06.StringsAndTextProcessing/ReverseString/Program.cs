/*  Problem 2. Reverse string
    =========================
    Write a program that reads a string, reverses it and prints the result at the console.
    ======================================================================================
    Example:
    input 	output
    sample 	elpmas
*/
using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter some symbols:");
        string inputSymbols = Console.ReadLine();
        Console.WriteLine("Reverse: {0}", Reverse(inputSymbols));
    }

    static string Reverse(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (var symbol in input)
        {
            result.Insert(0, symbol);
        }
        return result.ToString();
    }
}
