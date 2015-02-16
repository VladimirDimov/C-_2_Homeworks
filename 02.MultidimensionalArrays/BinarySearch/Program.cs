//  Problem 4. Binary search
//  ========================
//  Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
//  and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
//  =====================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] myArray;
        int integerK;
        int curInteger;
        int indexOfK = -1;  //largest number in the array which is ≤ K.

        Console.WriteLine("Enter some integers, separated by space:");
        myArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter the value of integer K:");
        integerK = int.Parse(Console.ReadLine());
        curInteger = integerK;
        Array.Sort(myArray);
        while (indexOfK <0)
        {            
            indexOfK = Array.BinarySearch(myArray, curInteger);
            curInteger--;
        }
        Console.WriteLine("The closest to {0} is {1}.", integerK, myArray[indexOfK]);
    }
}
