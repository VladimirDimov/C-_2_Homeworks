//  Problem 2. Random numbers
//  =========================
//  Write a program that generates and prints to the console 10 random values in the range [100, 200].
//  ==================================================================================================

using System;
using System.Collections.Generic;

class RandomNumbers
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> rndNumbers = new List<int>();
        
        Console.WriteLine("Generating 10 random values in the range [100, 200].");
        while (rndNumbers.Count < 10)
        {
            rndNumbers.Add(rnd.Next(100, 200));            
        }
        Console.Write("Random numbers: {0};\n", string.Join(", ", rndNumbers));
    }
}
