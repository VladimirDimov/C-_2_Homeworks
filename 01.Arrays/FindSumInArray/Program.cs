//  Write a program that finds in given array of integers a sequence of given sum S (if present).
//  Example:
//  array	                S	    result
//  4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        int[] myArray;
        int requestedSum;
        int currentSum;
        int startIndex;
        int endIndex;
        List<int[]> requestedSequences = new List<int[]>();
        int[] currentSequence;

        Console.WriteLine("Enter a sequence of numbers, separated by commas:");
        myArray = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter the requested sum:");
        requestedSum = int.Parse(Console.ReadLine());
        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = 0;
            for (int j = i; j < myArray.Length; j++)
            {
                currentSum += myArray[j];
                if (currentSum == requestedSum)
                {
                    startIndex = i;
                    endIndex = j;
                    currentSequence = new int[j - i + 1];
                    for (int k = i; k <= j; k++)
                    {
                        currentSequence[k-i] = myArray[k];
                    }
                    requestedSequences.Add(currentSequence);
                }
            }
        }
        if (requestedSequences.Count == 0)
        {
            Console.WriteLine(":( There are no sequences of the requested sum.");
        }
        else
        {
            Console.WriteLine(":) There are sequences ofthe requested sum:");
            foreach (var item in requestedSequences)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
    }
}
