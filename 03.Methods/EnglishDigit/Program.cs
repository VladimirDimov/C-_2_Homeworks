//Problem 3. English digit
//========================
//Write a method that returns the last digit of given integer as an English word.
//===============================================================================
//  Examples:
//  
//  input	output
//  ==============
//  512	    two
//  1024	four
//  12309	nine
//  ==============

using System;

class EnglishDigit
{
    static void Main()
    {
        int myNumber;
        int lastDigit;
        
        myNumber = int.Parse(Console.ReadLine());
        lastDigit = myNumber % 10;
        Console.WriteLine("The last digit is \"{0}\".", GetDigitName(lastDigit));
    }

    static string GetDigitName(int number)
    {
        string[] numbersNames = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        return numbersNames[number];
    }
}
