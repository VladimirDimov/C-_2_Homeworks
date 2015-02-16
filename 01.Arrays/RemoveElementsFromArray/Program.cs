//  Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array 
//  is sorted in increasing order.
//  Print the remaining sorted array.
//  =======================================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        char[] separators = {',', ' '};
        Console.WriteLine("Enter a sequence of integer numbers, separated by commas:");
        int[] myArray = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int right = (int)Math.Pow(2, myArray.Length);
        int[] currentSubset;
        int maxSubsetLength = 0;
        int[] longestSubset = new int[]{};
        int left = 1;

        for (int i = right - 1; i >= 1; i--)
        {
            currentSubset = getSubset(myArray, i);
            if (isIncreasing(currentSubset) && currentSubset.Length > maxSubsetLength)
            {
                maxSubsetLength = currentSubset.Length;
                longestSubset = currentSubset;
                left = (int)Math.Pow(2, currentSubset.Length);
            }
        }
        Console.WriteLine("The longest increasing sequence is:");
        Console.WriteLine(string.Join(" ", longestSubset));
    }

    static int[] getSubset(int[] array, int number)
    {
        int resultIndex = 0;
        int sourseIndex = 0;
        int[] result = new int[CountElements(number)];
        while (number != 0)
        {
            if ((number & 1) == 1)
            {
                result[resultIndex] = array[sourseIndex];
                resultIndex++;
            }
            number >>= 1;
            sourseIndex++;
        }
        return result;
    }

    static int CountElements(int number)
    {
        int counter = 0;
        while (number != 0)
        {
            if ((number & 1) == 1)
            {
                counter++;
            }
            number >>= 1;
        }
        return counter;
    }

    static bool isIncreasing(int[] array)
    {
        for (int i = 0; i <= array.Length-2; i++)
        {
            if (array[i] > array[i+1])
            {
                return false;
            }
        }
        return true;    
    }
}
