//Problem 15.* Number calculations
//================================
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).
//========================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter some numbers, separated by singlespace:");
        double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
        Console.WriteLine("The minimum value is: {0}", GetMinimum<double>(numbers));
        Console.WriteLine("The maximum value is: {0}", GetMaximum<double>(numbers));
        Console.WriteLine("The average value is: {0}", GetAverage<double>(numbers));
        Console.WriteLine("The value of the sum is: {0}", GetSum<double>(numbers));
        Console.WriteLine("The value of the product is: {0}", GetProduct<double>(numbers));
    }

    static T GetMinimum<T>(T[] numbers)
    {
        return numbers.Min();
    }

    static T GetMaximum<T>(T[] numbers)
    {
        return numbers.Max();
    }

    static double GetAverage<T>(T[] numbers)
    {
        dynamic sum = 0;
        foreach (var item in numbers)
        {
            sum = sum + item;
        }
        return sum/numbers.Length;
    }

    static T GetSum<T>(T[] numbers)
    {
        dynamic sum = 0;
        foreach (T item in numbers)
        {
            sum = sum + item;
        }
        return sum;
    }

    static T GetProduct<T>(T[] numbers)
    {
        dynamic result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
}

