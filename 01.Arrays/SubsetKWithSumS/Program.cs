//  Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//  Find in the array a subset of K elements that have sum S or indicate about its absence.
//  ========================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetKWithSumS
{
    static void Main()
    {
        char[] separators = {',', ' '};
        int arrayLength;
        int numberOfKElements;
        int requestedSum;
        int[] myArray;
        int currentSum;
        int temp;
        int index;
        int mask;
        List<int> currentResult = new List<int>();
        bool isResult = false;

        Console.WriteLine("Enter array length:");
        arrayLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integer numbers, separated by commas:", arrayLength);
        myArray = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        if (myArray.Length != arrayLength)
        {
            Console.WriteLine("The array must contain {0} elements!", arrayLength);
            return;
        }
        Console.WriteLine("Enter number of K elements:");
        numberOfKElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter requested sum:");
        requestedSum = int.Parse(Console.ReadLine());

        int left = (int)Math.Pow(2, numberOfKElements);
        int right = (int)Math.Pow(2, arrayLength);
        for (int i = 0; i < right; i++)
        {
            temp = i;
            index = 0;
            currentSum = 0;
            currentResult.Clear();
            while (temp != 0)
            {
                mask = temp & 1;
                if (mask == 1)
                {
                    currentSum += (mask) * myArray[index];
                    currentResult.Add(mask * myArray[index]);
                }
                temp >>= 1;
                index++;
            }
            if (currentResult.Count == numberOfKElements && currentSum == requestedSum)
            {
                isResult = true;
                Console.Write("Result: " + string.Join(" + ", currentResult));
                Console.WriteLine();
            }
        }
        if (isResult == false)
        {
            Console.WriteLine("There is no sequence of {0} numbers to equal {1}", numberOfKElements, requestedSum);
        }

    }
}
