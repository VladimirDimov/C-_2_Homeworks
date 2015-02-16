//  Problem 3. Decimal to hexadecimal
//  =================================
//  Write a program to convert decimal numbers to their hexadecimal representation.
//  ==============================================================================

using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {

        Console.Write("Enter the decimal representation of a positive integer: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Hexadecimal representation: {0}", DoDecimalToHexadecimal(decimalNumber));
    }

    static string DoDecimalToHexadecimal(int decimalInput)
    {
        if (decimalInput == 0)
        {
            return "0";
        }

        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        StringBuilder hexOutput = new StringBuilder();
        int currentDigit;

        while (decimalInput != 0)
        {
            currentDigit = decimalInput % 16;
            hexOutput.Insert(0, hexDigits[currentDigit]);
            decimalInput /= 16;
        }
        return hexOutput.ToString();
    }
}
