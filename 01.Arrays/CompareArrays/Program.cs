//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the first array numbers on a single line, separated by space:");
        int[] firstArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter the second array numbers on a single line, separated by space:");
        int[] secondArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Arrays must be with equal size!");
            return;
        }
        Console.WriteLine("Comparing element by element:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
            }
        }
    }
}
