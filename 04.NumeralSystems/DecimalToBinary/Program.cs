//  Problem 1. Decimal to binary
//  ============================
//  Write a program to convert decimal numbers to their binary representation.
//  ==========================================================================

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        int binaryNumber = 0;
        Console.Write("Enter the decimal representation of an integer: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        if (decimalNumber > 0)
        {
            binaryNumber = DecimalToBinaryMethod(decimalNumber);
        }
        else if (decimalNumber == 0)
        {
            binaryNumber = 0;
        }
        Console.WriteLine("Binary representation: {0}", binaryNumber);
    }

    static int DecimalToBinaryMethod(int decimalNumber)
    {
        StringBuilder binaryText = new StringBuilder();
        while (decimalNumber != 0)
        {
            binaryText.Insert(0, decimalNumber % 2);
            decimalNumber /= 2;
        }
        return int.Parse(binaryText.ToString());
    }
}
