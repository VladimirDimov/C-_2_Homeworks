/*
    Problem 18. Extract e-mails
    ===========================
    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
    ==================================================================================================
    examle:
    This program checks for valid email adresses. A valid e-mail is in the format identifier@host.domain. 
*/

using System;
using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            const string MatchEmailPattern =
                       @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                       + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                       + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,10})";
            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            // Report on each match.
            Console.WriteLine("Printing valid e-mails:");
            foreach (Match match in matches)
            {
                Console.WriteLine("e-mail: {0}", match.Value.ToString());
            }
        }
    }

    
