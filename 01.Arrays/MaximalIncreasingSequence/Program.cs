/* 
Write a program that finds the maximal increasing sequence in an array.
3, 2, 3, 4, 2, 2, 4
*/

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter some integer numbers separated by commas or spaces:");
        int[] numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int curNumber = numbers[0];
        int prevNumber = numbers[0] - 1;
        int curSequenceLength = 0;
        int maxSequenceLength = 0;
        string maxSequenceNumbers = null;
        string curSequenceNumbers = null;


        for (int i = 0; i < numbers.Length; i++)
        {
            curNumber = numbers[i];
            if (curNumber == prevNumber +1)
            {
                curSequenceLength++;
                curSequenceNumbers += " " + curNumber.ToString();
            }
            if (curNumber != prevNumber + 1 || i == numbers.Length -1)
            {
                if (maxSequenceLength < curSequenceLength)
                {
                    maxSequenceLength = curSequenceLength;
                    maxSequenceNumbers = curSequenceNumbers;
                    curSequenceLength = 1;
                    curSequenceNumbers = curNumber.ToString();
                }
            }
            prevNumber = curNumber;
        }
        Console.WriteLine("The max increasing sequence is: {0}",  maxSequenceNumbers);
        Console.ReadLine();
    }
}
