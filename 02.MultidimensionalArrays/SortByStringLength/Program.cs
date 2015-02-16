//  Problem 5. Sort by string length
//  ================================
//  You are given an array of strings. Write a method that sorts the array by the length of its elements 
//  (the number of characters composing them).
//  ====================================================================================================
//  {aa aaa a aaaaaaa aaa aaa aaaaa aaaaaaaaaaaaaaaaaaa}

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        string[] myArray;
        int[] corresponding;

        Console.WriteLine("Enter some strings separated by a single space:");
        myArray = Console.ReadLine().Split();
        corresponding= new int[myArray.Length];
        for (int i = 0; i < myArray.Length; i++)
        {
            corresponding[i] = myArray[i].Length;
        }
        Array.Sort(corresponding, myArray);
        Console.WriteLine("\nSorted Array by elements length:");
        foreach (var item in myArray)
        {
        Console.WriteLine(item);
        }
    }
}
