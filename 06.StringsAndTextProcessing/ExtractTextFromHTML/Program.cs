/*
    Problem 25. Extract text from HTML
    ==================================
    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
    =====================================================================================================================
    Example input:
    --------------------------------------------------------
    <html>
      <head><title>News</title></head>
      <body><p><a href="http://academy.telerik.com">Telerik
        Academy</a>aims to provide free real-world practical
        training for young people who want to turn into
        skilful .NET software engineers.</p></body>
    </html>
    
    Output:
    --------------------------------------------------------
    Title: News
    
    Text: Telerik Academy aims to provide free real-world practical training for young people who want to 
    turn into skilful .NET software engineers.
*/

using System;
using System.Text;
using System.Collections.Generic;

class ExtractTextFromHTML
{
    static void Main()
    {
        string title = null;
        string curLine = "Initial text";
        StringBuilder text = new StringBuilder();
        StringBuilder bodyText = new StringBuilder();
        List<string> htmlCode = new List<string>();
        string bodyCode = null;
        bool isInsideTag = false;

        Console.WriteLine("Enter some HTML code:");
        while (!curLine.Contains("</html>"))
        {
            curLine = Console.ReadLine();
            htmlCode.Add(curLine);
        }
        string htmlText = string.Join("", htmlCode);

        //extract title
        int titleStartIndex = htmlText.IndexOf("<title>") + 7;
        int titleEndIndex = htmlText.IndexOf("</title>");
        title = htmlText.Substring(titleStartIndex, titleEndIndex - titleStartIndex);   
        
        //extract body
        int bodyStartIndex = htmlText.IndexOf("<body>") + 6;
        int bodyendIndex = htmlText.IndexOf("</body>");
        bodyCode = htmlText.Substring(bodyStartIndex, bodyendIndex - bodyStartIndex);
        foreach (var symbol in bodyCode)
        {
            if (symbol == '<')
            {
                isInsideTag = true;
            }
            else if (symbol == '>')
            {
                isInsideTag = false;
            }
            else if (isInsideTag == false)
            {
                bodyText.Append(symbol);
            }
        }

        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Text: {0}", RemoveSpaces(bodyText.ToString()));
    }

    static string RemoveSpaces(string text)
    {
        return string.Join(" ",text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    }
}
