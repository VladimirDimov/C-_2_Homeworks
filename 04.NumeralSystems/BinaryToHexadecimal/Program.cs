//  Problem 6. binary to hexadecimal
//  ================================
//  Write a program to convert binary numbers to hexadecimal numbers (directly).
//  ============================================================================

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        ulong binaryInput = ulong.Parse(Console.ReadLine());
        if (!isValidBase(binaryInput, 2))
        {
            return;
        }
        Console.Write("Hexadecimal representation: ");
        Console.WriteLine(BinToHex(binaryInput));
    }

    static string BinToHex(ulong binaryInput)
    {
        if (binaryInput == 0)
        {
            return "0";
        }
        char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        StringBuilder hexText = new StringBuilder();
        ulong curretFourSum;
        int subPower;

        while (binaryInput != 0)
        {
            curretFourSum = 0;
            subPower = 0;
            for (int i = 0; i < 4; i++)
            {
                curretFourSum += binaryInput % 10 * (ulong)Math.Pow(2, subPower);
                binaryInput /= 10;
                if (binaryInput == 0)
                {
                    break;
                }
                subPower++;
            }
            hexText.Insert(0, hexDigits[curretFourSum]);
        }
        return hexText.ToString();
    }

    static bool isValidBase(ulong binNumber, byte numericBase)
    {
        byte curNumber;
        while (binNumber != 0)
        {
            curNumber = (byte)(binNumber % 10);           
            if (curNumber >= numericBase)
            {
                Console.WriteLine("Invalid number!");
                return false;
            }
            binNumber /= 10;
        }
        return true;
    }
}
