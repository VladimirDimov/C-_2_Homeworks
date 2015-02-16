/*
Problem 8. Replace whole word
=============================
Modify the solution of the previous problem to replace only whole words (not strings).
======================================================================================
*/

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

class ReplaceWholeWord
{
    static void Main()
    {
        StringBuilder rewriteLine = new StringBuilder();
        const string start = "start";
        const string finish = "finish";
        string filePath;
        string currentLine = null;
        List<string> allLines = new List<string>();

        Console.WriteLine("Enter input file path:");
        filePath = Console.ReadLine();
        StreamReader reader = new StreamReader(filePath);

        while ((currentLine = reader.ReadLine()) != null)
        {
            currentLine = ReplaceWord(currentLine, start, finish);
            allLines.Add(currentLine);
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(filePath, false);

        foreach (var line in allLines)
        {
            writer.WriteLine(line);
        }
        writer.Close();
    }

    public static String ReplaceWord(String s, String word, String bywhat)
    {
        bool hasReplacements = false;
        int rightIndex = 0;
        int leftIndex = 0;
        StringBuilder result = new StringBuilder();

        while (true)
        {
            if (leftIndex >= s.Length-1)
            {
                break;
            }
            rightIndex = s.IndexOf(word, leftIndex);
            if (rightIndex == -1)
            {
                break;
            }
            result.Append(s.Substring(leftIndex, rightIndex - leftIndex));
            if ((rightIndex == 0 || !char.IsLetterOrDigit(s[rightIndex - 1])) && ((rightIndex + word.Length - 1 == s.Length - 1) || !char.IsLetterOrDigit(s[rightIndex + word.Length])))
            {
                hasReplacements = true;
                result.Append(bywhat);
                leftIndex = rightIndex + bywhat.Length-1;
            }
            else
            {
                result.Append(word);
                leftIndex = rightIndex + word.Length;
            }
        }
        if (!hasReplacements)
        {
            return s;
        }
        else
        {
            return result.ToString();
        }
    }
}
