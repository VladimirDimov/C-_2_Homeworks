//  Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes 
//  algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        const int numberOfPrimes = 10000000;
        bool[] numbers = new bool[numberOfPrimes];

        //make all non-primes true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                for (int j = 2 * i + 1; j < numbers.Length; j += i + 1)
                {
                    numbers[j] = true;                
                }
  
            }
        }
        //printing positions with value "false"
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]==false)
            {
                Console.Write(i+1 + " ");
            }
        }
    }

}
