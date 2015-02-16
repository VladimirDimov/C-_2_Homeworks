//  Problem 20.* Variations of set
//  ===============================
//  Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//  ==================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class VariationsOfSet
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the set of numbers \"K\":");
        int setLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the variations \"N\":");
        int variationsLength = int.Parse(Console.ReadLine());

        int[] CurVariation = new int[variationsLength];
        for (int i = 0; i < CurVariation.Length; i++)
        {
            CurVariation[i] = 1;
        }
        Console.WriteLine("Printing variations:");
        while (CurVariation[CurVariation.Length - 1] != setLength+1)
        {
            Console.WriteLine(string.Join(" ", CurVariation));
            CurVariation[0]++;
            for (int i = 0; i < CurVariation.Length - 1; i++)
            {
                if (CurVariation[i] == setLength + 1)
                {
                    CurVariation[i] = 1;
                    CurVariation[i + 1]++;
                }
            }
        }
        Console.ReadLine();
    }
}
