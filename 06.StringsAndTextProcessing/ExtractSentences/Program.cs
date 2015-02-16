/*
    Problem 8. Extract sentences
    ============================
    Write a program that extracts from a given text all sentences containing given word.
    ====================================================================================
    Example:
    
    The word is: in
    
    The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    
    The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
    
    Consider that the sentences are separated by . and the words – by non-letter symbols.
*/
using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        StringBuilder tempString = new StringBuilder();
        StringBuilder result = new StringBuilder();

        Console.WriteLine("Enter sometext:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the requested word:");
        string requestedWord = Console.ReadLine();

        foreach (var symbol in text)
        {
            tempString.Append(symbol);
            if (symbol == '.')
            {
                    if (isContaining(tempString.ToString(), requestedWord))
                    {
                        result.Append(tempString);
                    }
                tempString.Clear();
            }
        }

        Console.WriteLine(result.ToString());
    }

    static bool isContaining(string input, string requestedWord)
    {
        int index = 0;
        while (index>=0)
        {
            index = input.IndexOf(requestedWord, index);
            if (index<0)
            {
                return false;
            }
            else if (index == 0)
            {
                if (!char.IsLetter(input[index + requestedWord.Length]))
                {
                    return true;
                }
            }
            else if (0 < index && index < input.Length - requestedWord.Length)
            {
                if (!char.IsLetter(input[index -1]) && 
                    !char.IsLetter(input[index + requestedWord.Length]))
                {
                    return true;
                }
            }
            else if (index == input.Length - requestedWord.Length && !char.IsLetter(input[index - 1]))
            {
                return true;
            }
            index += requestedWord.Length-1;
        }
        return false;    
    }
}
