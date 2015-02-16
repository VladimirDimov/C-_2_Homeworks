//  Problem 5. Hexadecimal to binary
//  ================================
//  Write a program to convert hexadecimal numbers to binary numbers (directly).
//  ============================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a positive hexadecimal number: ");
        string hexInput = Console.ReadLine();
        if (!isVallidHex(hexInput))
        {
            return;
        }
        Console.WriteLine("Binary representation: " + HexToBin(hexInput));
    }

    static int HexToBin(string hexInput)
    {
        StringBuilder binaryText = new StringBuilder();
        int currentDec = 0;
        int[] currDecArray = new int[4];
        int power = 0;
        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        Stack<char> hexInputStack = new Stack<char>();
        foreach (var hexDigit in hexInput)
        {
            hexInputStack.Push(hexDigit);
        }
        while (hexInputStack.Count != 0)
        {
            currentDec = Array.BinarySearch(hexDigits, hexInputStack.Pop()) * (int)Math.Pow(16, power);
            for (int i = 0; i < 4; i++)
            {
                binaryText.Insert(0, currentDec%2);
                currentDec /=2;
            }
        }        
        return int.Parse(binaryText.ToString());
    }

    static bool isVallidHex(string input)
    {
        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        foreach (var hexDigit in input)
        {
            if (!hexDigits.Contains(hexDigit))
            {
                Console.WriteLine("Invalid hexadecimal");
                return false;
            }
        }
        return true;
    }
}
