//  Problem 7.* Largest area in matrix
//  ==================================
//  Write a program that finds the largest area of equal neighbour elements in a rectangular matrix
//  and prints its size.
//  ===============================================================================================
//  Example:   Result: 13
//  5
//  6
//  1
//  3
//  2
//  2
//  2
//  4
//  3
//  3
//  3
//  2
//  4
//  4
//  4
//  3
//  1
//  2
//  3
//  3
//  4
//  3
//  1
//  3
//  3
//  1
//  4
//  3
//  3
//  3
//  1
//  1

using System;
using System.Collections.Generic;

class LargestAreaInAMatrix
{
    static int currentCounter = 0;
    static int maxCounter = 0;
    const string counted = "counted";
    static void Main()
    {
        string[,] myArray;
        string[] currentRowItems;
        int numberOfRows;
        int numberOfColumns;
        string currentValue;

        Console.WriteLine("Enter number of rows:");
        numberOfRows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns:");
        numberOfColumns = int.Parse(Console.ReadLine());
       
        myArray = new string[numberOfRows, numberOfColumns];
        currentRowItems = new string[numberOfRows];
        Console.WriteLine("Enter arrays rows on separate lines.");
        Console.WriteLine("Split elements by a singlespace");
        for (int row = 0; row < numberOfRows; row++)
        {
            currentRowItems = Console.ReadLine().Split();
            for (int col = 0; col < numberOfColumns; col++)
            {
                myArray[row, col] = currentRowItems[col];
            }
        }

        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                currentValue = myArray[row, col];
                if (currentValue != counted)
                {
                    getLinkedItems(myArray, row, col, currentValue);
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                    }
                    currentCounter = 0;
                }
            }
        }
        Console.WriteLine("the largest area of equal neighbour elements is: " + maxCounter);
    }

    static void getLinkedItems(string[,] array, int row, int col, string value)
    {
        currentCounter++;
        array[row, col] = counted;
        if (row != array.GetLength(0)-1 && array[row+1, col] == value)  // down
        {
            getLinkedItems(array, row + 1, col, value);
        }
        if (row!= 0 && array[row-1, col] == value)                      // up
        {
            getLinkedItems(array, row - 1, col, value);
        }
        if (col != 0 && array[row, col-1] == value)                     // left
        {
            getLinkedItems(array, row, col-1, value);
        }
        if (col != array.GetLength(1)-1 && array[row, col + 1] == value)     // right
        {
            getLinkedItems(array, row, col + 1, value);
        }
    }
}
