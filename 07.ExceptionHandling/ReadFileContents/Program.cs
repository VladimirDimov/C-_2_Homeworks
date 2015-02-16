/*
Problem 3. Read file contents
=============================
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
==============================================================================================
*/

using System;
using System.IO;

    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Enter file path:");

            try
            {
                StreamReader reader = new StreamReader(Console.ReadLine());
                Console.WriteLine("File Content:");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AccessViolationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
