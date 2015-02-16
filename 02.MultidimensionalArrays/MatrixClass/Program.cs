//  Problem 6.* Matrix class
//  ========================
//  Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
//  subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
//  =================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;


namespace MyNamespace
{
    class MatrixClass
    {
        static void Main()
        {
            Console.WriteLine("Enter some integers, separated by a single space:");
            int[] myArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("\nThe converted matrix looks like:");
            Console.WriteLine("{{{0}}}", string.Join(" ", Matrix.String(myArray)));           
        }
    }

    static class Matrix
    {
        public static string[] String(int[] array)
        {
            string[] result = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i].ToString();
            }
            return result;
        }
    }
}