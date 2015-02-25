/*
Problem 11. Format number
=========================
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
=================================================================================================================================
*/

using System;

class FormatNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("Decimal: {0}", number);
        Console.WriteLine("Hexadecimal: {0}", Convert.ToString((int)number, 16).ToUpper());
        Console.WriteLine("Percentage: {0} %", number);
        Console.WriteLine("Scientific notation: {0}", GetScientific(number));
    }

    static string GetScientific(double number)
    {
        int power = 0;
        if (Math.Abs(number) < 1)
        {
            while (Math.Abs(number)<1)
            {
                number *= 10;
                power--;
            }
        }
        else
        {
            while (Math.Abs(number) > 10)
            {
                number /= 10;
                power++;
            }
        }
        if (power >= 0)
        {
            return string.Format("{0} x 10^{1}", number, power);
        }
        else
        {
            return string.Format("{0} x 10^({1})", number, power);
        }
    }
}
