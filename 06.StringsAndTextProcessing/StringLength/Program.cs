/*  Problem 6. String length
    ========================
    Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
    ================================================================================================
*/

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter somestringth with length up to 20 chars:");
        StringBuilder text = new StringBuilder();
        text.Append(Console.ReadLine());
        if (text.Length < 20)
        {
            text.Append(new string('*', 20 - text.Length));
        }
        for (int i = 1; i < 21; i++)
        {
            Console.Write('|');
        }
        Console.WriteLine();
        Console.WriteLine(text.ToString());
    }
}
