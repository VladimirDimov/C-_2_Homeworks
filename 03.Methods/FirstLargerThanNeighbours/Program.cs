//  Problem 6. First larger than neighbours
//  =======================================
//  Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//  Use the method from the previous exercise.
//  ==========================================================================================================================================

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] myArray;

        Console.WriteLine("Enter some integers, separated by a single space:");
        myArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("The first larger than it's neighbours:");
        Console.WriteLine("Index [{0}]", GetFirstLargerThanNeighbours(myArray));
    }

    static bool IsLargerThanNeighbours(int[] array, int index)
    {
        bool isLarger = true;
        if (index > 0 && array[index] <= array[index - 1])
        {
            isLarger = false;
        }
        if (index < array.Length - 1 && array[index] <= array[index + 1])
        {
            isLarger = false;
        }
        return isLarger;
    }

    static int GetFirstLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargerThanNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }

}
