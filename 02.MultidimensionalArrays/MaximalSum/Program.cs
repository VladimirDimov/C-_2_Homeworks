//  Problem 2. Maximal sum
//  ======================
//  Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
//  ====================================================================================================================================
//  3
//  4
//  3
//  4
//  5
//  8
//  7
//  9
//  5
//  3
//  2
//  5
//  6
//  8



using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[,] matrix;
        int[,] curSubMatrix = new int[3,3];
        int[,] maxSubMatrix = new int[3, 3];

        Console.WriteLine("Enter rows number:");
        int rows = int.Parse(Console.ReadLine());
        if (rows < 3)
        {
            Console.WriteLine("Rows number must be at least 3!");
            return;
        }
        Console.WriteLine("Enter columns number:");
        int cols = int.Parse(Console.ReadLine());
        if (cols < 3)
        {
            Console.WriteLine("Cols number must be at least 3!");
            return;
        }

        int currentSum;
        int maxSum = 0;

        matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix looks like:");
        PrintMatrix(matrix);

        for (int row = 1; row <= rows-2; row++)
        {
            for (int col = 1; col <= cols-2; col++)
            {
                currentSum = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        currentSum += matrix[row + i, col + j];
                        curSubMatrix[1 + i, 1 + j] = matrix[row + i, col + j];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSubMatrix = (int[,])curSubMatrix.Clone();
                }
            }
        }
        Console.WriteLine("The maximum sum of square 3x3 is: {0}", maxSum);
        Console.WriteLine("at:\n");
        PrintMatrix(maxSubMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
