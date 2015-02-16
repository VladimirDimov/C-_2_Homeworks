//  Write a program that reads two integer numbers N and K and an array of N elements from the console.
//  Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        int sizeOfArray;
        double[] numbers;
        double[] kValues;
        int kElements;

        Console.WriteLine("Enter the size of the array");
        sizeOfArray = int.Parse(Console.ReadLine());
        numbers = new double[sizeOfArray];
        Console.WriteLine("Enter {0} numbers on separate lines:", sizeOfArray);
        for (int i = 0; i < sizeOfArray; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the number of K elements:");
        kElements = int.Parse(Console.ReadLine());
        Array.Sort(numbers);
        kValues = new double[kElements];
        for (int i = 0; i < kElements; i++)
        {
            kValues[i] = numbers[numbers.Length - 1 - i];
        }
        Console.WriteLine("The K elements with maximal sum are: {0}", string.Join(", ", kValues));
        Console.WriteLine(string.Join(" + ", kValues) + " = " + kValues.Sum());
    }
}
