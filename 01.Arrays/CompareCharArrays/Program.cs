//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter two strings with the same length in two separate lines:");
        char[] firstCharArray = Console.ReadLine().ToCharArray();
        char[] secondCharArray = Console.ReadLine().ToCharArray();

        int length = Math.Min(firstCharArray.Length, secondCharArray.Length); 

        for (int i = 0; i < length; i++)  // Compare until the smaller array length is reached
        {
            if (firstCharArray[i] > secondCharArray[i])
            {
                Console.WriteLine("{0} is after {1} lexicographically", firstCharArray[i], secondCharArray[i]);
            }
            else if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine("{0} is before {1} lexicographically", firstCharArray[i], secondCharArray[i]);                
            }
            else
            {
                Console.WriteLine("{0} and {1} are lexicographically equal", firstCharArray[i], secondCharArray[i]);
            }
        }

    }
}
