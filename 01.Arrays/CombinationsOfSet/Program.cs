//  Problem 21.* Combinations of set
//  ================================
//  Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsOfSet
{
    static int[] curCombination;

    static void Main()
    {
        int[] setOfNumbers;
        Console.WriteLine("Enter the length of the set of numbers \"K\":");
        int setLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the combination \"N\":");
        int combinationLength = int.Parse(Console.ReadLine());
        setOfNumbers = new int[setLength];
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            setOfNumbers[i] = i + 1;
        }

        Console.WriteLine("Printing variations:");
        curCombination = new int[combinationLength];
        Combinations(setOfNumbers, 0, combinationLength, curCombination, 0);

        Console.ReadLine();
    }

    static void Combinations(int[] setOfNumbers, int leftResult, int combinationLength, int[] curCombination, int leftInput)
    {
        if (leftResult == combinationLength)
        {
            Console.WriteLine(string.Join(" ", curCombination));
            return;
        }
        for (int i = leftInput; i < setOfNumbers.Length; i++)
        {
            curCombination[leftResult] = setOfNumbers[i];
                Combinations(setOfNumbers, leftResult + 1, combinationLength, curCombination, i+1);
        }
    }
}
