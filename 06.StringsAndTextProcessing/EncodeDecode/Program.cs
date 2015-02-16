/*
    Problem 7. Encode/decode
    ========================
    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the 
    string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
    ===================================================================================================================================
*/

using System;
using System.Text;

namespace EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string inputText = Console.ReadLine();
            
            Console.WriteLine("Enter your key:");
            string key = Console.ReadLine();
            
            string encodedText = EncodeText(inputText, key);
            
            Console.WriteLine("Encoded text: {0}", encodedText);
            
            Console.WriteLine("Enter the key again to decode:");
            key = Console.ReadLine();
            
            Console.WriteLine("Decoded text:");
            Console.WriteLine(DecodeText(encodedText, key));
        }

        static string EncodeText(string inputText, string key)
        {
            StringBuilder text = new StringBuilder();
            text.Append(inputText);
            for (int index = 0; index < text.Length; index++)
            {
                text[index] = (char)(key[index % key.Length] ^ text[index]);
            }
            return text.ToString();
        }

        static string DecodeText(string encodedText, string key)
        {
            StringBuilder text = new StringBuilder();
            text.Append(encodedText);
            for (int index = 0; index < text.Length; index++)
            {
                text[index] = (char)(key[index % key.Length] ^ text[index]);
            }
            return text.ToString();
        }
    }
}
