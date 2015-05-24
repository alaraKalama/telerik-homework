using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
namespace ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().Trim();
            string[] text = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

            foreach (string word in text)
            {
                if (Regex.IsMatch(word, regex))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
