//  Problem 13. Solve tasks
//  =======================
//  Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//  Create appropriate methods.
//  Provide a simple text-based menu for the user to choose which task to solve.
//  Validate the input data:
//  The decimal number should be non-negative
//  The sequence should not be empty
//  a should not be equal to 0
//  =============================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Enter a number of the following operations:\n");
        Console.WriteLine("********************MENU*********************");
        Console.WriteLine("1  Reverse the digits of a number.");
        Console.WriteLine("2  Calculate the average of several numbers.");
        Console.WriteLine("3  Solve a linear equation.");
        Console.WriteLine("*********************************************");

        int choise = int.Parse(Console.ReadLine());
        if (choise == 1)
        {
            CommandReverseDigits();
        }
        else if (choise == 2)
        {
            CommandGetAverage();
        }
        else if (choise == 3)
        {
            CommandSolveLinearEquation();
        }
        else
        {
            Console.WriteLine("Invalid option!");
            return;
        }
    }

    static void CommandSolveLinearEquation()
    {
        double a;
        double b;
        Console.WriteLine("You have chosen to solve a linear equation.");
        Console.WriteLine("The equation is in the format ax + b = 0");
        Console.Write("Enter a value for \"a\":");
        a = double.Parse(Console.ReadLine());
        if (isNonZero(a) == false)
        {
            Console.WriteLine("\"a\" should not equal zero!");
            return;
        }
        Console.Write("Enter a value for \"b\":");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("x = {0}", SolveLinearEquation(a, b));    
    }

    static void CommandReverseDigits()
    {
        Console.WriteLine("You have chosen to reverse the digits of a number.");
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());
        if (isValidNumber(number))
        {
            Console.WriteLine("The reversed number is: {0}", ReverseDigits(number));
        }
        else
        {
            Console.WriteLine("The number should be non-negative!");
        }
    }

    static bool isValidNumber(int number)
    {
        if (number < 0)
        {
            return false;
        }
        else
        {
            return true;
        }    
    }

    static void CommandGetAverage()
    {
        Console.WriteLine("You have chosen to find the average of several numbers.");
        Console.WriteLine("Enter somenumbers, separated by a singlespace:");
        double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
        if (isValidSequence(numbers))
        {
            Console.WriteLine("The average value is: {0}", GetAverage(numbers));
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static bool isValidSequence(double[] numbers)
    {
        if (numbers.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int ReverseDigits(int number)
    {
        StringBuilder reversed = new StringBuilder();
        while (number != 0)
        {
            reversed.Append(number % 10);
            number /= 10;
        }
        return int.Parse(reversed.ToString());
    }

    static double GetAverage(double[] numbers)
    {
        return numbers.Sum() / numbers.Length;
    }

    static double SolveLinearEquation(double a, double b)
    {
        return (-1) * b / a;    
    }

    static bool isNonZero(double number)
    {
        if (number != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
