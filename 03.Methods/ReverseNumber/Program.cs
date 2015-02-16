//  Problem 7. Reverse number
//  =========================
//  Write a method that reverses the digits of given int number.
//  ================================================================
//  Example:
//  input	    output
//  256	    652
//  ================================================================

using System;

class ReverseNumber
{
    static void Main()
    {
        int number;

        Console.WriteLine("Enter an integer number:");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Note that the leading zeros are removed!");
        Console.WriteLine("The reversed number is: {0}", ReverseDigits(number));
    }

    static int ReverseDigits(int number)
    {
        string temp = null;
        for (int i = 0; i < number.ToString().Length; i++)
        {
            temp = number.ToString()[i] + temp;
        }
        return int.Parse(temp);
    }
}
