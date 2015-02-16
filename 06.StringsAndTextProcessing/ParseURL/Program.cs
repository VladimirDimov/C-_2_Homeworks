/*
    Problem 12. Parse URL
    =====================
    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts 
    from it the [protocol], [server] and [resource] elements.
    ==============================================================================================================
    Example:
    
    URL	Information
    http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
    [server] = telerikacademy.com 
    [resource] = /Courses/Courses/Details/212
*/

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        StringBuilder reader = new StringBuilder();
        string protocol;
        string server;
        string resource;
        int firstSplitIndex = 0;
        int secondSplitIndex;

        Console.Write("Enter a valid URL:");
        string url = Console.ReadLine();

        //read protocol
        firstSplitIndex = url.IndexOf("://");
        protocol = url.Substring(0, firstSplitIndex);

        //read server
        secondSplitIndex = url.IndexOf("/", firstSplitIndex + 3);
        server = url.Substring(firstSplitIndex + 3, secondSplitIndex - firstSplitIndex - 3);


        //read resource
        resource = url.Substring(secondSplitIndex, url.Length - secondSplitIndex);

        Console.WriteLine("[Protocol] = {0}", protocol);
        Console.WriteLine("[Server] = {0}", server);
        Console.WriteLine("[Resource] = {0}", resource);

    }
}
