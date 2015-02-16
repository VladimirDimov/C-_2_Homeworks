using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] myArray;
        int requestedValue;
        int index;

        Console.WriteLine("Enter a sequence of numbers, separated by commas:");
        myArray = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        Array.Sort(myArray);
        Console.WriteLine("Sorted array: {{{0}}}", string.Join(", ", myArray));
        Console.WriteLine("Enter requested value");
        requestedValue = int.Parse(Console.ReadLine());
        index = DoBinarySearch(myArray, requestedValue, 0, myArray.Length - 1);
        if (index == -1)
        {
            Console.WriteLine("Value not found");
        }
        else
        {
            Console.WriteLine("The index of the requested vaue is [{0}]", index);
        }
    }

    static int DoBinarySearch(int[] myArray, int searchValue, int left, int right)
    {
        int result = searchValue - 1;
        int index;
        int curValue;

        index = (left + right) / 2;
        curValue = myArray[index];

        if (curValue == searchValue)
        {
            return index;
        }
        else if(left != right)
        {
            if (curValue < searchValue)
            {
                return DoBinarySearch(myArray, searchValue, index + 1, right);
            }
            else
            {
                return DoBinarySearch(myArray, searchValue, 0, index-1);
            }
        }
        else
        {
            return -1;
        }
    }
}
