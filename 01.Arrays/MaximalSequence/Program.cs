/* 
Write a program that finds the maximal sequence of equal elements in an array.
2, 1, 1, 2, 3, 3, 2, 2, 2, 1
0, 0, 0, 3, 4, 4, 4
*/

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter some integer numbers separated by commas:");
        int[] numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int curNumber = numbers[0];
        int prevNumber = numbers[0];
        int curSequenceLength = 0;
        int maxSequenceLength = 0;
        int maxSequenceNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            curNumber = numbers[i];

            if (curNumber == prevNumber)
            {
                curSequenceLength++;
            }
            if (curNumber != prevNumber || i == numbers.Length - 1)
            {
                if (maxSequenceLength < curSequenceLength)
                {
                    maxSequenceLength = curSequenceLength;
                    maxSequenceNumber = numbers[i - 1];
                }
                curSequenceLength = 1;
            }
            prevNumber = curNumber;
        }
        Console.WriteLine("The max sequence length is {0} with number {1}", maxSequenceLength, maxSequenceNumber);
    }
}
