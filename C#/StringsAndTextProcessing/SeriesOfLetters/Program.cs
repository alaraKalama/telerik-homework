using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
namespace SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter something:");
            string input = Console.ReadLine().Trim();
            StringBuilder letters = new StringBuilder();
            letters.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i-1])
                {
                    letters.Append(input[i]);
                }
            }

            Console.WriteLine(letters.ToString());

        }
    }
}
