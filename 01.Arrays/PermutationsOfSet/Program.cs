//  Problem 19.* Permutations of set
//  ================================
//  Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//  ===========================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class PermutationsOfSet
{
    static void Main()
    {
        char[] separators = {',',' '};
        Console.WriteLine("Enter the number of integers:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers, separated by commas:", length);
        int[] myArray = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        if (myArray.Length !=length)
        {
            Console.WriteLine("You said there wouldbe {0} integers", length);
            return;
        }
        Console.WriteLine("Printing all permutations:");
        GetPermutations(myArray, 0, myArray.Length);
    }

    static void GetPermutations(int[] array, int i, int n)
    {
        if (i == n)
            Console.WriteLine(string.Join(" ", array));
        else
        {
            for (int j = i; j < n; j++)
            {
                SwapElements(array, i, j);
                GetPermutations(array, i + 1, n);
            }
        }
    }

    static void SwapElements(int[] arr, int firstIndex, int secondIndex)
    {
        int temp;
        temp = arr[firstIndex];
        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = temp;
    }
}
