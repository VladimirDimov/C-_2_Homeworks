//  Problem 2. Binary to decimal
//  ============================
//  Write a program to convert binary numbers to their decimal representation.
//  ==========================================================================

using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        BigInteger binaryInput;
        BigInteger decimalOutput;
        Console.Write("Enter the binary representation of an BigIntegereger: ");
        binaryInput = BigInteger.Parse(Console.ReadLine());
        decimalOutput = DoBinaryToDecimal(binaryInput);
        Console.WriteLine("Decimal representation: {0}", decimalOutput);
    }

    static BigInteger DoBinaryToDecimal(BigInteger binaryInput)
    {
        BigInteger decimalOutput = 0;
        BigInteger currentBinaryDigit;
        ulong power = 0;
        while (binaryInput != 0)
        {
            currentBinaryDigit = binaryInput % 10;
            decimalOutput += currentBinaryDigit * (BigInteger)Math.Pow(2, power);
            power++;
            binaryInput /= 10;
        }
        return decimalOutput;
    }
}
