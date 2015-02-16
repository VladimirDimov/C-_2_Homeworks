//  Problem 9. Sorting array
//  ========================
//  Write a method that return the maximal element in a portion of array of integers starting at given index.
//  Using it write another method that sorts an array in ascending / descending order.
//  =========================================================================================================

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter some integers, separated by a single space:");
        int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        Console.WriteLine();
        Console.WriteLine("Print ascending:");
        Sort(array, true);
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();

        Console.WriteLine("Print descending:");
        Sort(array, false);
        Console.WriteLine(string.Join(" ", array));
        Console.ReadLine();
    }

    static int GetMaxValue(int[] array, int startIndex, int endIndex)
    {
        int result = int.MinValue;
        int maxValue = int.MinValue;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i]>maxValue)
            {
                maxValue = array[i];
                result = i;
            }
        }
        return result;    
    }

    static void Sort(int[] array, bool isAscending)
    {
        int temp;
        int tempMaxIndex;
        if (isAscending==true)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                temp = array[i];
                tempMaxIndex = GetMaxValue(array, 0, i);
                array[i] = array[tempMaxIndex];
                array[tempMaxIndex] = temp;
            }
        }
        else
        {
            for (int i = 0; i <= array.Length-1; i++)
            {
                temp = array[i];
                tempMaxIndex = GetMaxValue(array, i, array.Length-1);
                array[i] = array[tempMaxIndex];
                array[tempMaxIndex] = temp;
            }
        }
    }
}
