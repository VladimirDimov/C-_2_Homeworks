//  Problem 10. N Factorial
//  =======================
//  Write a program to calculate n! for each n in the range [1..100].
//  Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
//  ===============================================================================================================

using System;
using System.Collections.Generic;

class NFactorial
{
    static void Main()
    {
        int number;
        List<int> result = new List<int>();
            Console.WriteLine("Input an integer in the range [1, 100]:");
            number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("{0}! =  {1}", 1, 1);
                return;
            }
            if (number < 1)
            {
                Console.WriteLine("Number must be bigger than zero!");
                return;
            }

            result = Factorial(NumberToList(number), number - 1);
            result.Reverse();
            Console.WriteLine("{0}! =  {1}", number, string.Join("", result));
    }

    static List<int> Factorial(List<int> digits, int number)
    {
        List<int> currentProduct = new List<int>();
        if (number == 1)
        {
            return digits;
        }
        else
        {
            currentProduct = MultiplyListToInt(digits, number);
            return Factorial(currentProduct, number - 1);
        }    
    }

    static List<int> MultiplyListToInt(List<int> digits, int number)
    {
        List<int> result = new List<int>();
        int reminder = 0;
        int curProduct;

        for (int i = 0; i <= digits.Count - 1; i++)
        {
            curProduct = digits[i] * number + reminder;
            result.Add(curProduct % 10);
            reminder = curProduct / 10;
        }
        while (reminder != 0)
        {
            result.Add(reminder % 10);
            reminder /= 10;
        }
        return result;
    }

    static List<int> NumberToList(int number)
    {
        List<int> result = new List<int>();
        while (number != 0)
        {
            result.Add(number % 10);
            number /= 10;
        }
        return result;
    }
}
