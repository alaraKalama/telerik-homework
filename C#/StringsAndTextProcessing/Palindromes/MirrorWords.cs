using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
namespace Palindromes
{
    class MirrorWords
    {
        static void Main()
        {
            Console.WriteLine("Enter text. Better have some palindromes...");
            string input = Console.ReadLine().Trim();
            string[] text = input.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\'', '"'}, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder palindromes = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];
                string reversed = new string(currentWord.ToCharArray().Reverse().ToArray());
                if (currentWord == reversed)
                {
                    palindromes.Append(currentWord + " ");
                }
            }

            Console.WriteLine("{0} ",palindromes.ToString());
        }
    }
}
