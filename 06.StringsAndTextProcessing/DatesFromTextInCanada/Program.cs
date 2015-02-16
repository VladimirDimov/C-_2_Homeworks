/*
    Problem 19. Dates from text in Canada
    =====================================
    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
    ===========================================================================================
*/

using System;
using System.Threading;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        Console.WriteLine("Enter some text with dates:");
        string text = Console.ReadLine();
        DateTime currentDate;

        string[] words = text.Split();
        foreach (var word in words)
        {
            if (DateTime.TryParseExact(word, "dd.MM.yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out currentDate))
            {
                Console.WriteLine(Convert.ToString(currentDate.ToShortDateString()));
            }
        }
    }
}
