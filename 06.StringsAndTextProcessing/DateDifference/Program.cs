/*
    Problem 16. Date difference
    ===========================
    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
    ==================================================================================================================
    Example:
    
    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days
*/

using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        CultureInfo provider = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter start date:");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", provider);

        Console.WriteLine("Enter end date:");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", provider);

        int difference = (int)(endDate - startDate).TotalDays;

        Console.WriteLine("Distance: {0} days", difference);        
    }
}
