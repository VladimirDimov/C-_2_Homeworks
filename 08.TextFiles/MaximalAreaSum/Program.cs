/*
Problem 5. Maximal area sum
===========================
Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
=============================================================================
Example:

input	    output
4 
2 3 3 4 
0 2 3 4 
3 7 1 2 
4 3 3 2	    17
*/

using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        int[,] matrix;
        int[] curLine;
        int size;
        int currentSum = 0;
        int maxSum = 0;

        Console.WriteLine("Enter file path:");
        StreamReader reader = new StreamReader(Console.ReadLine());
        size = int.Parse(reader.ReadLine());
        curLine = new int[size];
        matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            curLine = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            for (int col = 0; col < curLine.Length; col++)
            {
                matrix[row, col] = curLine[col];
            }
        }

        for (int row = 0; row < size-1; row++)
        {
            for (int col = 0; col < size-1; col++)
            {
                currentSum = 0;
                for (int rowOffset = 0; rowOffset < 2; rowOffset++)
                {
                    for (int colOffset = 0; colOffset < 2; colOffset++)
                    {
                        currentSum += matrix[row + rowOffset, col + colOffset];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine("Maximal sum: {0}", maxSum);
        reader.Close();
    }
}
