//  Problem 7. One system to any other
//  ===================================
//  Write a program to convert from any numeral system of given base s to 
//  any other numeral system of base d (2 ≤ s, d ≤ 16).
//  =====================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        int inputBase;
        string inputNumber;
        int outputBase;
        string result = null;

        Console.Write("Enter input numeric base: ");
        inputBase = int.Parse(Console.ReadLine());
        if (inputBase < 0 || inputBase > 16)
        {
            Console.WriteLine("Invalid output base");
            return;
        }

        Console.Write("Enter a number with base {0}: ", inputBase);
        inputNumber = Console.ReadLine();
        if (!isValidNumber(inputNumber, inputBase))
        {
            return;
        }
        Console.Write("Enter output number base: ");
        outputBase = int.Parse(Console.ReadLine());
        if (outputBase< 0 || outputBase > 16)
        {
            Console.WriteLine("Invalid output base");
            return;
        }
        if (inputNumber == "0")
        {
            result = "0";
        }
        else
        {
            result = ConvertBase(inputNumber, inputBase, outputBase);
        }
        Console.WriteLine("The {0} base representation lookslike: {1}", outputBase, result);
    }

    static string ConvertBase(string inputNumber, int inputBase, int outputBase)
    {
        int decNumber = 0;
        int curPower = 0;;
        StringBuilder result = new StringBuilder();
        int curDigitValue;
        char[] allDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        Stack<char> inputStack = new Stack<char>();

        //Convert number to decimal
        foreach (var digit in inputNumber)
        {
            inputStack.Push(digit);
        }
        if (inputBase != 10)
        {
            while (inputStack.Count != 0)
            {
                curDigitValue = Array.BinarySearch(allDigits, inputStack.Pop());
                decNumber += curDigitValue * (int)Math.Pow(inputBase, curPower);
                curPower++;
            }
        }
        else
        {
            decNumber = int.Parse(inputNumber);
        }

        //Convert decimal to any base
        while (decNumber != 0)
        {
            curDigitValue = decNumber % outputBase;
            result.Insert(0, allDigits[curDigitValue]);
            decNumber /= outputBase;
        }
        return result.ToString();
    }

    static bool isValidNumber(string number, int numericBase)
    {
        char[] allDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        char[] subArray = new char[numericBase];
        Array.Copy(allDigits, subArray, numericBase);
        foreach (var digit in number)
        {
            if (!subArray.Contains(digit))
            {
                Console.WriteLine("Invalid input");
                return false;
            }
        }
        return true;
    }
}
