/*
    Problem 15. Replace tags
    ========================
    Write a program that replaces in a HTML document given as string all the tags 
    <a href="…">…</a> with corresponding tags [URL=…]…/URL].
    =============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter some HTML code:");
            string htmlText = Console.ReadLine();

            htmlText = htmlText.Replace("<a href=\"", "[URL=");
            htmlText = htmlText.Replace("\">", "]");
            htmlText = htmlText.Replace("</a>", "[/URL]");

            Console.WriteLine("Formated text:");
            Console.WriteLine(htmlText);
        }
    }
}
