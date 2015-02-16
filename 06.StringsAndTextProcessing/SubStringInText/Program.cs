/*  Problem 4. Sub-string in text
    =============================
    Write a program that finds how many times a sub-string is contained in a given text 
    (perform case insensitive search).
    ===================================================================================
    Example:
    
    The target sub-string is in
    
    The text is as follows: 
    We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    
    The result is: 9
*/

using System;
using System.Text;

class SubStringInText
{
    static void Main()
    {
        int currentIndex = 0; ;
        int counter = 0;

        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a substring:");
        string substring = Console.ReadLine();

        while (currentIndex >= 0)
        {
            currentIndex = text.IndexOf(substring, currentIndex);
            if (currentIndex > 0)
            {
                counter++;
                currentIndex++;
            }
        }
        Console.WriteLine("The text contains {0} times \"{1}\".", counter, substring);
    }
}
