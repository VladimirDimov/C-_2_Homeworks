//Problem 14. Integer calculations
//================================
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
//======================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter some numbers, separated by singlespace:");
        int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("The minimum value is: {0}", GetMinimum(numbers));
        Console.WriteLine("The maximum value is: {0}", GetMaximum(numbers));
        Console.WriteLine("The average value is: {0}", GetAverage(numbers));
        Console.WriteLine("The value of the sum is: {0}", GetSum(numbers));
        Console.WriteLine("The value of the product is: {0}", GetProduct(numbers));
    }

    static int GetMinimum(int[] numbers)
    {
        
        return numbers.Min();
    }

    static int GetMaximum(int[] numbers)
    {
        return numbers.Max();
    }

    static double GetAverage(int[] numbers)
    {
        return numbers.Average();
    }

    static int  GetSum(int[] numbers)
    {
        return numbers.Sum();
    }

    static int GetProduct(int[] numbers)
    {
        int result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
}
