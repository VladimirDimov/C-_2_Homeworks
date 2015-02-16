//  Problem 3. Sequence n matrix
//  =============================
//  We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//  neighbour elements located on the same line, column or diagonal.
//  Write a program that finds the longest sequence of equal strings in the matrix.
//  =====================================================================================================
//  Matrix 1:               Matrix 2:
//  3                       4
//  3                       4
//  aa	                    qwe
//  asd	                    zxc
//  we	                    sdf
//  qwe	                    jkl
//  aa	                    qwe
//  asd	                    qwe
//  ert	                    56y
//  trer                    t78i
//  aa	                    qwe
//                          tyru
//                          qwe
//                          ggj
//                          qwe
//                          rt
//                          ret
//                          ytry


using System;
using System.Collections.Generic;
using System.Linq;

class SequenceNMatrix
{
    static string[,] matrix;
    static int maxElementLength = 0;
    static string maxSequenceName = null;

    static void Main()
    {
        int numberOfColumns;
        int numberOfRows;
        int maxSequenceValue = 0;
        int currentSequenceVal = 0;


        Console.WriteLine("Enter number of rows:");
        numberOfRows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numebr of columns:");
        numberOfColumns = int.Parse(Console.ReadLine());
        matrix = new string[numberOfRows, numberOfColumns];
        Console.WriteLine("Enter matrix values row by row and each element on a new line:");
        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                matrix[row, col] = Console.ReadLine();
                if (maxElementLength < matrix[row, col].Length)
                {
                    maxElementLength = matrix[row, col].Length;
                }
            }
        }

        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                currentSequenceVal = CheckSequence(matrix, row, col);
                if (currentSequenceVal > maxSequenceValue)
                {
                    maxSequenceValue = currentSequenceVal;
                    maxSequenceName = matrix[row, col];
                }
            }
        }
        Console.WriteLine("The string \"{0}\" has a sequence of {1} elements.", maxSequenceName, maxSequenceValue);
        Console.WriteLine("The matrix looks like:\n");
        PrintMatrix(matrix);

    }

    static int CheckSequence(string[,] array, int row, int col)
    {
        int curRow = row;
        int curCol = col;
        string CheckedValue = array[row, col];
        int counter;
        int maxSequence = 0;

        //Check right
        counter = 1;
        curCol = col;
        curRow = row;
        while (curCol != array.GetLength(1) - 1)
        {
            curCol++;
            if (array[curRow, curCol] == CheckedValue)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        if (maxSequence < counter)
        {
            maxSequence = counter;
        }

        //check down
        counter = 1;
        curCol = col;
        curRow = row;
        while (curRow != array.GetLength(0) - 1)
        {
            curRow++;
            if (array[curRow, curCol] == CheckedValue)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        if (maxSequence < counter)
        {
            maxSequence = counter;
        }

        //check down-right diagonal    
        counter = 1;
        curCol = col;
        curRow = row;
        while (curCol != array.GetLength(1) - 1 && curRow != array.GetLength(0) - 1)
        {
            curCol++;
            curRow++;
            if (array[curRow, curCol] == CheckedValue)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        if (maxSequence < counter)
        {
            maxSequence = counter;
        }
        return maxSequence;
    }

    static void PrintMatrix(string[,] matrix)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != maxSequenceName)
                {
                    Console.ForegroundColor = defaultColor;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("{0}", matrix[row, col].PadLeft(maxElementLength+1));
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = defaultColor;
    }
}
