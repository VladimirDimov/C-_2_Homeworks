//  Problem 11. Adding polynomialials
//  ==============================
//  Write a method that adds two polynomialials.
//  Represent them as arrays of their coefficients.
//  ===============================================
//  Example:
//  x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;
using System.Collections;
using System.Collections.Generic;


class Addingpolynomialials
{
    static void Main()
    {
        string firstPolynomialText;
        string secondPolynomialText;
        int[] firstPolynomialMatrix;
        int[] secondPolynomialMatrix;

        Console.WriteLine("Enter the first polynomial:");
        firstPolynomialText = Console.ReadLine();
        Console.WriteLine("Enter the second polynomial:");
        secondPolynomialText = Console.ReadLine();

        firstPolynomialMatrix = ReadPolynomial(firstPolynomialText);
        secondPolynomialMatrix = ReadPolynomial(secondPolynomialText);

        Console.WriteLine("The first matrix looks like: {{{0}}}", string.Join(", ",firstPolynomialMatrix));
        Console.WriteLine("The second matrix looks like: {{{0}}}", string.Join(", ",secondPolynomialMatrix));
        Console.WriteLine("Adding polynomials: {{{0}}}", string.Join(", ", AddPolynomials(firstPolynomialMatrix, secondPolynomialMatrix)));
    }

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result;
        if (firstPolynomial.Length>=secondPolynomial.Length)
        {
            result = firstPolynomial;
            for (int i = 0; i < secondPolynomial.Length; i++)
            {
                result[i] += secondPolynomial[i];
            }
        }
        else
        {
            result = secondPolynomial;
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                result[i] += firstPolynomial[i];
            }
        }
        return result;    
    }

    static int[] ReadPolynomial(string polynomialText)
    {
        int[] polynomial;
        int[] curElementValues = new int[2];
        char[] separators = new char[] { ' ', '+', '-' };
        string[] polynomialElements = polynomialText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Stack<int> signs = new Stack<int>();

        foreach (var item in polynomialText)
        {
            if (item == '+')
            {
                signs.Push(1);
            }
            else if (item == '-')
            {
                signs.Push(-1);
            }
        }

        polynomial = new int[GetPolynomialPower(polynomialElements) + 1];

        foreach (var item in polynomialElements)
        {
            curElementValues = ReadElement(item);
            polynomial[curElementValues[1]] = curElementValues[0];
        }

        for (int i = 0; i < polynomial.Length; i++)
        {
            if (signs.Count > 0 && polynomial[i] != 0)
            {
                polynomial[i] *= signs.Pop();
            }
        }
        return polynomial;
    }

    static int[] ReadElement(string element)
    {
        int[] elementValues = new int[2];
        string[] splitElement = element.Split(new char[]{'x'}, StringSplitOptions.None);
        if (element.Contains("x"))
        {
            if (element[0] == 'x')
            {
                elementValues[0] = 1;
            }
            else
            {
                elementValues[0] = int.Parse(splitElement[0]);
            }
            if (element[element.Length - 1] == 'x')
            {
                elementValues[1] = 1;
            }
            else
            {
                elementValues[1] = int.Parse(splitElement[splitElement.Length - 1]);
            }
        }
        else
        {
            elementValues[0] = int.Parse(element);
            elementValues[1] = 0;
        }
        return elementValues;
    }

    static int GetPolynomialPower(string[] elements)
    {
        int polynomialPower = 0;
        foreach (var item in elements)
        {
            if (ReadElement(item)[1] > polynomialPower)
            {
                polynomialPower = ReadElement(item)[1];
            }
        }
        return polynomialPower;
    }
}
