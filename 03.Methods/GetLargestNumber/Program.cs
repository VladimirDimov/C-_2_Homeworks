//Problem 2. Get largest number
//=============================
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
//================================================================================================================

using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        int[] integers = new int[3];
        int maxInteger;

        Console.WriteLine("Enter three numbers, separated by a singlespace:");
        integers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        maxInteger = GetMax(GetMax(integers[0], integers[1]), integers[2]);
        Console.WriteLine("The biggest number is: {0}", maxInteger);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
