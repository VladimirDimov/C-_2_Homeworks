/*  Problem 3. Correct brackets
    ===========================
    Write a program to check if in a given expression the brackets are put correctly.
    ====================================================================================
    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/
using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter an expression");
        string expression = Console.ReadLine();
        int openingBrackets = 0;
        int closingBrackets = 0;
        bool isRight = true;

        foreach (var symbol in expression)
        {
            if (symbol == '(')
            {
                openingBrackets++;
            }
            else if (symbol == ')')
            {
                closingBrackets++;
            }
            if (closingBrackets > openingBrackets)
            {
                isRight = false;
                break;
            }
        }
        if (openingBrackets != closingBrackets)
        {
            isRight = false;
        }
        Console.WriteLine(isRight ? "The brackets in the expression are corrrect!" : "The brackets in the expression are incorrect!");
    }
}
