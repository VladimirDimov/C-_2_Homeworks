//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//===============================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetWithSumS
{
    static void Main()
    {
        char[] separators = {',', ' '};
        int[] myArray;
        int requestedSum;
        int currentSum = 0;
        int resultsCouter = 0;
        List<int> currentResult = new List<int>();
        bool isResut = false;

        Console.WriteLine("Enter some integer numbers, separated by commas:");
        myArray = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter requested sum:");
        requestedSum = int.Parse(Console.ReadLine());
        for (int i = 0; i < Math.Pow(2, myArray.Length) ; i++)
        {
            currentSum = 0;
            currentResult.Clear();
            for (int j = 0; j < myArray.Length; j++)
            {
                if ((i >> j & 1) == 1)
                {
                    currentSum += (i >> j & 1) * myArray[j];
                    currentResult.Add((i >> j & 1) * myArray[j]);
                }
            }
            if (currentSum == requestedSum && currentResult .Count != 0)
            {
                isResut = true;
                resultsCouter++;
                Console.Write("{0,2} result: ",resultsCouter);
                Console.Write(string.Join(" + ", currentResult));
                Console.WriteLine();
            }
        }
        if (isResut == false)
        {
            Console.WriteLine("There are no combinations that give sum of {0}.", requestedSum);
        }
    }
}
