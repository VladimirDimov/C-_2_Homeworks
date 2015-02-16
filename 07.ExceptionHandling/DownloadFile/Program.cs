/*
Problem 4. Download file
========================
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
===========================================================================================================
*/

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient downloader = new WebClient();

        Console.WriteLine("Enter an URL:");
        Uri uri = new Uri(Console.ReadLine());
        string url = "http://telerikacademy.com/Content/Images/news-img01.png";
        Console.WriteLine("Enter an output location:");
        string outputFile = Console.ReadLine();
        try
        {
            downloader.DownloadString(Console.ReadLine());
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        downloader.Dispose();
    }
}
