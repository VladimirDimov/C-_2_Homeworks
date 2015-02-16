/* 
Problem 1. Fill the matrix
==========================
Write a program that fills and prints a matrix of size (n, n) as shown.
*/






using System;
using System.Collections.Generic;
using System.Linq;

class FillТheМatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrixes:");
        int size = int.Parse(Console.ReadLine());
        int[,] matrixA = new int[size, size];
        int[,] matrixB = new int[size, size];
        int[,] matrixC = new int[size, size];
        int[,] matrixD = new int[size, size];
        int row;
        int col;
        int counter;

        //Matrix a)
        counter = 0;
        for (col = 0; col < size; col++)
        {
            for (row = 0; row < size; row++)
            {
                counter++;
                matrixA[row, col] = counter;
            }
        }
        Console.WriteLine("Matrix a):\n");
        PrintMatrix(matrixA);

        //Matrix b)

        const string down = "down";
        const string up = "up";
        string direction = down;
        counter = 0;
        for (col = 0; col < size; col++)
        {
            for (row = 0; row < size; row++)
            {
                counter++;
                if (direction == down)
                {
                    matrixB[row, col] = counter;
                }
                else
                {
                    matrixB[size - row - 1, col] = counter;
                }
            }
            if (direction == down)
            {
                direction = up;
            }
            else
            {
                direction = down;
            }
        }
        Console.WriteLine("Matrix b):\n");
        PrintMatrix(matrixB);

        //Matrix c)
        counter = 0;
        row = size - 1;
        col = 0;
        for (counter = 1; counter <= size * size; counter++)
        {
            matrixC[row, col] = counter;
            if (row == size - 1 && col < size - 1)
            {
                row = size - 2 - col;
                col = 0;
            }
            else if (col == size - 1 && row < size - 1)
            {
                col = size - row;
                row = 0;
            }
            else if (row == size - 1 && col == size - 1)
            {
                row = 0;
                col = 1;
            }
            else
            {
                row++;
                col++;
            }
        }
        Console.WriteLine("Matrix c):\n");
        PrintMatrix(matrixC);

        // Matrix d)*
        const string right = "right";
        const string left = "left";
        direction = down;
        counter = 0;
        row = 0;
        col = 0;
        do
        {
            counter++;
            matrixD[row, col] = counter;

            if (direction == down)
            {
                if (row+1 != size && matrixD[row + 1, col] == 0)
                {
                    row++;
                }
                else
                {
                    direction = right;
                    col++;
                }
            }
            else if (direction == right)
            {
                if (col+1!=size && matrixD[row, col+1] == 0 )
                {
                    col++;
                }
                else
                {
                    direction = up;
                    row--;
                }

            }
            else if (direction == up)
            {
                if (row != 0 && matrixD[row - 1, col] == 0 )
                {
                    row--;
                }
                else
                {
                    direction = left;
                    col--;
                }

            }
            else if (direction == left)
            {
                if (col != 0 && matrixD[row, col-1] == 0 )
                {
                    col--;
                }
                else
                {
                    direction = down;
                    row++;
                }
            }
        } while (counter != size*size);
        Console.WriteLine("Matrix d)*:\n");
        PrintMatrix(matrixD);
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
