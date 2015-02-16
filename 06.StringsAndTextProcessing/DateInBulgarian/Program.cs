/*
    Problem 17. Date in Bulgarian
    =============================
    Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
    and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day 
    of week in Bulgarian.
    =================================================================================================
    15.02.2015 22:30:30
*/

using System;
using System.Threading;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string format = "dd.MM.yyyy HH:mm:ss";
        string[] daysOfWeek = {"Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя"};

        Console.WriteLine("Enter date and time in the format \"dd.MM.yyyy HH:mm:ss\":");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, null);
        
        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine("Time after 6 hours and 30 minutes:");

        Console.WriteLine("{0}, {1:dd.MM.yyyy HH:mm:ss}", daysOfWeek[(int)date.DayOfWeek-1], date);
    }
}
