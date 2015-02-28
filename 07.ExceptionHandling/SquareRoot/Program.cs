/*
Problem 1. Square root
======================
Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
========================================================================================
*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter some positive number: ");
        
        try
        {
            double number = double.Parse(Console.ReadLine());
           if (number < 0)
           {
               throw new FormatException();
           }
           Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine(fe.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

