//  Problem 8. Binary short
//  =======================                                       
//  Write a program that shows the binary representation of given 
//  16-bit signed integer number (the C# type short).             
//  ==============================================================

using System;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        StringBuilder binary = new StringBuilder();

        Console.WriteLine("Insert an integer number in the range [0, 65535]:");
        ushort number = ushort.Parse(Console.ReadLine());
       
        for (int i = 15; i >= 0; i--)
        {
            binary.Append( number >> i & 1);
        }
       
        Console.WriteLine("Binary number:");
        Console.WriteLine(binary.ToString());
    }
}
