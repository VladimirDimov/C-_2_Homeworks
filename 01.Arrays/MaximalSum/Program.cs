//  Write a program that finds the sequence of maximal sum in given array.
//  input 	                            result
//  2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] myArray;
        int[] maxSequence;
        int currentSum;
        int maxSum = int.MinValue;
        int maxSumStartIndex = 0;
        int maxSumEndIndex = 0;

        Console.WriteLine("Enter the elements of an array, separated by commas:");
        myArray = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();

        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = 0;
            for (int j = i; j < myArray.Length; j++)
            {
                currentSum += myArray[j];
                if (currentSum > maxSum)
                {
                    maxSumStartIndex = i;
                    maxSumEndIndex = j;
                    maxSum = currentSum;
                }
            }
        }
        maxSequence = new int[maxSumEndIndex - maxSumStartIndex + 1];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = myArray[i + maxSumStartIndex];
        }
        Console.WriteLine("The sequence of maximal sum is ... {0} ...", string.Join(", ", maxSequence));
    }
}
