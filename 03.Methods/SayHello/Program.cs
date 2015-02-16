//  Problem 1. Say Hello
//  ====================
//  Write a method that asks the user for his name and prints “Hello, <name>”
//  Write a program to test this method.
//  =========================================================================

using System;

class SayHello
{
    static void Main()
    {
        string personName;
        Console.WriteLine("Enter a name of a person:");
        personName = Console.ReadLine();
        Greet(personName);
    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello {0}!", name);    
    }
}
