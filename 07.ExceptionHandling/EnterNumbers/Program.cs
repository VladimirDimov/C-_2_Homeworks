/*
Problem 2. Enter numbers
========================
Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
=========================================================================================================
*/

using System;
using System.Collections.Generic;

class EnterNumbers
{
    static void Main()
    {
        ReadNumber(1, 100);
        
    }

    static void ReadNumber(int start, int end)
    {
        int currentNumber;       
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter ten numbers, such that {0} <= a1 < … < a10 <= {1}", start, end);
        while (numbers.Count < 10)
        {
            try
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (start > currentNumber || currentNumber > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                numbers.Add(currentNumber);
                start = currentNumber + 1;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Number isoutside of the allowed range!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine(fe.Message);
            }
            catch
            {
                Console.WriteLine("Fatal exception");
            }
        }
        Console.WriteLine(string.Join(" < ", numbers));
    }
}
