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
        Console.WriteLine("Percentage: {0} %", number * 100);
        unfinished
    }
}
