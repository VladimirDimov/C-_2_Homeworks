//  Write a program that finds the most frequent number in an array.
//  input	                                    result
//  4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)


using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        int[] myArray;
        List<int> mostFrequentNumbers = new List<int>();
        int mostRepetitions;
        Dictionary<int, int> occurances = new Dictionary<int, int>();

        Console.WriteLine("Enter the elements of an array, separated by commas:");
        myArray = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();

        foreach (var item in myArray)
        {
            if (occurances.ContainsKey(item))
            {
                occurances[item]++;
            }
            else
            {
                occurances.Add(item, 1);
            }
        }
        mostRepetitions = occurances.Values.Max();

        foreach (var item in occurances.Keys)
        {
            if (occurances[item] == mostRepetitions)
            {
                mostFrequentNumbers.Add(item);
            }
        }
        Console.WriteLine("The most frequent numbers are:");
        foreach (var item in mostFrequentNumbers)
        {
            Console.WriteLine("{0} with {1} occurances", item, mostRepetitions);
        }
    }
}
