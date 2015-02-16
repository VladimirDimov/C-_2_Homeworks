//  Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//  Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//  smallest from the rest, move it at the second position, etc.

//  3.5, -2.8, 6, 2.99, 100, 25.99, -38.4
//  2, 3, -6, -1, 2, -1, 6, 4, -8, 8

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        double[] myArray;
        double currentMin;
        double temp;
        int currentMinIndex;

        Console.WriteLine("Enter the elements of an array, separated by commas:");
        myArray = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => double.Parse(x)).ToArray();

        for (int i = 0; i < myArray.Length; i++)
        {
            currentMin = double.MaxValue;
            currentMinIndex = i;
            for (int j = i; j < myArray.Length; j++)
            {
                if (myArray[j] < currentMin)
                {
                    currentMin = myArray[j];
                    currentMinIndex = j;
                }
            }
            temp = myArray[i];
            myArray[i] = currentMin;
            myArray[currentMinIndex] = temp;
        }
        Console.WriteLine("Printing the sorted array:");
        Console.WriteLine(string.Join(", ", myArray));
    }
}
