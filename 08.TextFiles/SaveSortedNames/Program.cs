/*
Problem 6. Save sorted names
============================
Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
====================================================================================================================
Example:

input.txt	|    output.txt
------------|---------------
Ivan        |    George
Peter       |    Ivan
Maria       |    Maria
George	    |    Peter         
*/

using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();
        string currentName = null;

        //Console.WriteLine("Enter input File:");
        //StreamReader reader = new StreamReader(Console.ReadLine());
        StreamReader reader = new StreamReader("unsorted.txt");

        //Console.WriteLine("Enter output File:");
        //StreamWriter writer = new StreamWriter(Console.ReadLine());
        StreamWriter writer = new StreamWriter("sorted.txt");

        while ((currentName = reader.ReadLine()) != null)
        {
            names.Add(currentName);
        }

        names.Sort();
        foreach (var name in names)
        {
            writer.WriteLine(name);
        }

        reader.Close();
        writer.Close();
        Console.WriteLine("The sorted file path is:");
        Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + "sorted.txt");
    }
}
