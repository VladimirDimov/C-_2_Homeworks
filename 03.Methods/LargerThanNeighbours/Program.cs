//  Problem 5. Larger than neighbours
//  =================================
//  Write a method that checks if the element at given position in given array of integers 
//  is larger than its two neighbours (when such exist).
//  ======================================================================================

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] myArray;
        int index;
        string isLarger;

        Console.WriteLine("Enter some integers, separated by a single space:");
        myArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter a position to check:");
        index = int.Parse(Console.ReadLine());
        if (IsLargerThanNeighbours(myArray, index) == true)
        {
            isLarger = "is larger";
        }
        else
        {
            isLarger = "is not larger";
        }
        Console.WriteLine("The number {0} at position {1} {2} than it's neighbours.", myArray[index], index, isLarger);
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
}
