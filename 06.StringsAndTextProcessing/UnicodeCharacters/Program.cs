/*
    Problem 10. Unicode characters
    ===============================
    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
    ======================================================================================
    Example:
    
    input	output
    Hi!	\u0048\u0069\u0021
*/
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.WriteLine("Printingunicode iterals:");
        foreach (var character in text)
        {
            Console.Write(GetUnicodeLiteral(character));
        }
        Console.WriteLine();
    }

    static string GetUnicodeLiteral(char input)
    {
        StringBuilder literal = new StringBuilder();
        literal.Append("\\u");
        literal.Append(Convert.ToString((int)input,16).PadLeft(4, '0'));
        return literal.ToString();
    }
}
