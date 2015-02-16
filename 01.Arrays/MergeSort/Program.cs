//  Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class MergeSort
{
    static void Main()
    {
        int[] myArray;
        char[] separators = {',', ' '};
                
        Console.WriteLine("Enter a sequence of numbers, separated by commas:");
        //myArray = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        myArray = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        
        SelectSubArrays(myArray, 0, myArray.Length - 1);
        Console.WriteLine("Applying selection sort:");
        Console.WriteLine(string.Join(", ", myArray));
        Console.ReadLine();
    }

    static void SelectSubArrays(int[] array, int left, int right)
    {
        int middle = (left + right) / 2;

        if (right - left <=1)
        {
            SortSubArrays(array, left, right);
            return;
        }

        SelectSubArrays(array, left, middle);
        SelectSubArrays(array, middle + 1, right);
    }

    static void SortSubArrays(int[] array, int left, int right)
    {
        int temp;
        if (left == right)
        {
            return;
        }
        else
        {
            if (left>right)
            {
                temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }  
    }

    static void MergeSubArrays(int[] array, int left, int right, int middle)
    {
        int[] tempArray = new int[right - left + 1];
        int curposition = 0;
        int leftPosition = 0;
        int rightPosition = 0;

        while (curposition != tempArray.Length-1)
        {
            if (array[left+leftPosition] <= array[middle+1+rightPosition])
            {
                tempArray[curposition] = array[left + leftPosition];
                if (leftPosition <middle)
                {
                    leftPosition++;
                }
            }
            else
            {
                tempArray[curposition] = array[middle + 1 + rightPosition];
                if (rightPosition < right)
                {
                    rightPosition++;
                }
            }
            curposition++;
        }
        for (int i = 0; i < tempArray.Length; i++)
        {
            array[left + i] = tempArray[i];
        }
    }
}
