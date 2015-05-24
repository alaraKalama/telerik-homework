using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractFromHTML
{
    class Program
    {
        static void Main()
        {
            string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

            MatchCollection tags = Regex.Matches(text, @"((?<=^|>)[^><]+?(?=<|$))");
            int count = 1;

            foreach (Match tag in tags)
            {
                if (count == 1)
                {
                    Console.WriteLine("Title: {0}", tag);
                    Console.Write("Text: ");
                }
                else
                {
                    Console.Write(tag + " ");
                }
                count++;
            }
            Console.WriteLine();
        }
    }
}
