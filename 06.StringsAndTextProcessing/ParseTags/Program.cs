/*  Problem 5. Parse tags
    =====================
    You are given a text. Write a program that changes the text in all regions surrounded by the tags 
    <upcase> and </upcase> to upper-case.
    The tags cannot be nested.
    ==================================================================================================
    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

    The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        const string openingTag = "<upcase>";
        const string closingTag = "</upcase>";
        int openingIndex = 0;
        int closingIndex = 0;
        StringBuilder temp = new StringBuilder();

        StringBuilder text = new StringBuilder();
        Console.WriteLine("Enter some text:");
        text.Append(Console.ReadLine());

        while (openingIndex >= 0 && closingIndex >= 0)
        {
            openingIndex = text.ToString().IndexOf(openingTag, 0);
            closingIndex = text.ToString().IndexOf(closingTag, openingIndex + openingTag.Length);
            
            if (openingIndex >= 0 && closingIndex >= 0)
            {
                for (int index = openingIndex + openingTag.Length; index < closingIndex; index++)
                {
                    text[index] = char.ToUpper(text[index]);
                }
                text.Remove(closingIndex, closingTag.Length);
                text.Remove(openingIndex, openingTag.Length);
            }
        }
        Console.WriteLine("Formated text:");
        Console.WriteLine(text);
    }
}
