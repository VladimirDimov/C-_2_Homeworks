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

        string url = "http://telerikacademy.com/Content/Images/news-img01.png";

        try
        {
            Console.WriteLine("Enter an output location:");
            string outputLocation = Console.ReadLine();
            if (!System.IO.Directory.Exists(outputLocation))
            {
                throw new System.IO.DirectoryNotFoundException("The output folder was not found");
            }
            downloader.DownloadFile(url, outputLocation + @"\img.jpg");            
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (System.IO.DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch
        {
            Console.WriteLine("Unknown exception");
        }        
    }
}
