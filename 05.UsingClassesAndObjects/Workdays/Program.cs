//Problem 5. Workdays
//===================
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
//specified preliminary as array.
//========================================================================================================

using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Today is {0:dd.MM.yyyy}:", DateTime.Today);
        Console.WriteLine("Inser ending date:");
        DateTime futureDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        Console.WriteLine("From today to {0:dd.MM.yyyy} there are {1} working days.", futureDate, CalculateWorkdays(futureDate));    

    }

    static bool isHoliday(DateTime date)
    {
        DateTime[] holidays =
        {
         new DateTime(DateTime.Today.Year, 1,1),       
         new DateTime(DateTime.Today.Year, 3,3),
         new DateTime(DateTime.Today.Year, 5,6),
         new DateTime(DateTime.Today.Year, 3,3),
         new DateTime(DateTime.Today.Year, 9,22),
        };

        foreach (var day in holidays)
        {
            if (day.Month == date.Month && day.Day == date.Day)
            {
                return true;
            }
        }
        return false;
    }

    static int CalculateWorkdays(DateTime futureDate)
    {
        DateTime today = new DateTime();
        DateTime curDate = new DateTime();
        int workdays = 0;
        int[] restdays = { 0, 6 };

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        today = DateTime.Today;

        curDate = today;
        while (curDate != futureDate.AddDays(1))
        {
            if (!restdays.Contains((int)curDate.DayOfWeek) && !isHoliday(curDate))
            {
                workdays++;
            }
            curDate = curDate.AddDays(1);
        }
        return workdays;
    }
}
