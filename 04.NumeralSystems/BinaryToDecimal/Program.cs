//  Problem 2. Binary to decimal
//  ============================
//  Write a program to convert binary numbers to their decimal representation.
//  ==========================================================================

using System;

class BinaryToDecimal
{
    static void Main()
    {
        int binaryInput;
        int decimalOutput;
        Console.Write("Enter the binary representation of an integer: ");
        binaryInput = int.Parse(Console.ReadLine());
        decimalOutput = DoBinaryToDecimal(binaryInput);
        Console.WriteLine("Decimal representation: {0}", decimalOutput);
    }

    static int DoBinaryToDecimal(int binaryInput)
    {
        int decimalOutput = 0;
        int currentBinaryDigit;
        int power = 0;
        while (binaryInput != 0)
        {
            currentBinaryDigit = binaryInput % 10;
            decimalOutput += currentBinaryDigit * (int)Math.Pow(2, power);
            power++;
            binaryInput /= 10;
        }
        return decimalOutput;
    }
}
