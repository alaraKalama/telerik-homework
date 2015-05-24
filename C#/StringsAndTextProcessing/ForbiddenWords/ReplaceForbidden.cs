using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.


namespace ForbiddenWords
{
    class ReplaceForbidden
    {
        public static List<string> ForbiddenWords = new List<string> { "PHP", "CLR", "Microsoft" };
        static void Main()
        {
            string text = Console.ReadLine().Trim();
            string[] words = text.Split(new char[] {' ', '.'}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder censored = new StringBuilder();
            string censure = string.Empty;
            foreach (string word in words)
            {
                int lenght = word.Length;
                censure = word;
                if (ForbiddenWords.Contains(word))
                {
                    censure = new string('*', lenght);
                    
                }
               string newWord = word.Replace(word, censure);

               censored.Append(newWord + ' ');
            }

            Console.WriteLine(censored.ToString());
        }
    }
}
