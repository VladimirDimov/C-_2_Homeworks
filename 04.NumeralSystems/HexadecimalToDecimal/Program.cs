//Problem 4. Hexadecimal to decimal
//=================================
//Write a program to convert hexadecimal numbers to their decimal representation.
//===============================================================================

using System;
using System.Linq;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexInput;
        int decimalOutput;

        Console.Write("Enter the hexidecimal representation of a positive integer:");
        hexInput = Console.ReadLine();
        if (!isVallid(hexInput))
        {
            Console.WriteLine("Invalid input number");
            return;
        }
        decimalOutput = DoHexadecimalToDecimal(hexInput);
        Console.WriteLine("Decimal representation: {0}", decimalOutput);
    }

    static int DoHexadecimalToDecimal(string hexInput)
    {
        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int decimalOutput = 0;
        int hexToDecDigit;
        int power = 0;

        Stack<char> hexNumberStack = new Stack<char>();
        foreach (var hexDigit in hexInput)
        {
            hexNumberStack.Push(hexDigit);
        }

        while (hexNumberStack.Count != 0)
        {
            hexToDecDigit = Array.BinarySearch(hexDigits, hexNumberStack.Pop());
            decimalOutput += hexToDecDigit * (int)Math.Pow(16, power);
            power++;
        }
        return decimalOutput;
    }

    static bool isVallid(string input)
    {
        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        foreach (var hexDigit in input)
        {
            if (!hexDigits.Contains(hexDigit))
            {
                return false;
            }
        }
        return true;
    }
}
