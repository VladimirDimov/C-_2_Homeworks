/*
Problem 10. Extract text from XML
=================================
Write a program that extracts from given XML file all the text without the tags.
================================================================================
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
*/
//C:\Users\vladko\Desktop\1.txt

using System;
using System.IO;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string filePath;
        string text;
        bool isInsideTag = false;
        StringBuilder textWOTags = new StringBuilder();

        Console.WriteLine("Enter file path:");
        filePath = Console.ReadLine();

        StreamReader reader = new StreamReader(filePath);
        text = reader.ReadToEnd();
        reader.Close();
        foreach (var symbol in text)
        {
            if (symbol == '<')
            {
                if (isInsideTag == false)
                {
                    textWOTags.Append(' ');
                }
                isInsideTag = true;
            }
            else if (symbol == '>')
            {
                isInsideTag = false;                
            }
            else if (isInsideTag == false)
            {
                textWOTags.Append(symbol);
            }
        }

        StreamWriter writer = new StreamWriter(filePath, false);
        writer.Write(textWOTags.ToString());
        writer.Close();
    }
}
