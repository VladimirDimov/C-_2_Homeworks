//  Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//  Print the obtained array on the console.

using System;
using System.Collections.Generic;

class AllocateArray
{
    static void Main()
    {
        int[] myArray = new int[20];

        Console.WriteLine("Printing Array:" + "\n");
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = 5 * i;
        }
        Console.WriteLine(string.Join(" ", myArray));
    }
}
