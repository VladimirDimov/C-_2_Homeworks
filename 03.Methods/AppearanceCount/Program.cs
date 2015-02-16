//Problem 4. Appearance count
//===========================
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
//==============================================================================

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int[] myArray;
        int number;

        Console.WriteLine("Enter some integers, separated by a single space:");
        myArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter an integer:");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} appears {1} times in the array.", number, GetOccurances(myArray, number));
    }

    static int GetOccurances(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

}
