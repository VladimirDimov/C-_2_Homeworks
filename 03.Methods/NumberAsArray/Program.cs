//  Problem 8. Number as array
//  ==========================
//  Write a method that adds two positive integer numbers represented as arrays 
//  of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//  Each of the numbers that will be added could have up to 10 000 digits.
//  =========================================================================================

using System;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            byte[] firstNumber = new byte[10000];
            byte[] secondNumber = new byte[10000];
            byte[] sum;

            Console.WriteLine("Enter first number:");
            string firstNumberString = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string secondNumberString = Console.ReadLine();
            for (int i = 0; i < firstNumberString.Length; i++)
            {
                firstNumber[i] = byte.Parse(firstNumberString[firstNumberString.Length - 1 - i].ToString());
            }
            for (int i = 0; i < secondNumberString.Length; i++)
            {
                secondNumber[i] = byte.Parse(secondNumberString[secondNumberString.Length - 1 - i].ToString());
            }
            sum = AddNumbers(firstNumber, secondNumber);
            Console.WriteLine("The sum is:");
            for (int i = GetLength(sum)-1; i >= 0; i--)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
        }

        static byte[] AddNumbers(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = new byte[10000];
            for (int i = 0; i < firstNumber.Length; i++)
            {
                result[i] += (byte)((firstNumber[i] + secondNumber[i]) % 10);
                if (i < 9999)
                {
                    result[i + 1] = (byte)((firstNumber[i] + secondNumber[i]) / 10);
                }
            }
            return result;
        }

        static int GetLength(byte[] array)
        {
            int counter = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (array[i] != 0)
                {
                    counter = i + 1;
                }
            }
            return counter;
        }
    }
}
