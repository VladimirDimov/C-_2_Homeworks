//  Problem 1. Leap year
//  ====================
//  Write a program that reads a year from the console and checks whether it is a leap one.
//  Use System.DateTime.
//  =======================================================================================

using System;

    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter any year in format [yyyy]:");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 2, 28);

            if (date.AddDays(1).Month == 2)
            {               
                Console.WriteLine("It is a leap year!");
            }
            else
            {
                Console.WriteLine("It is not a leap year!");
            }
        }
    }
