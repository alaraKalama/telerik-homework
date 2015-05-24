using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all sentences containing given word.

namespace ExtractSentences
{
    class Extract
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            string[] sentences = input.Split('.', '!', '?');

            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < sentences.Length; i++)
            {
                string currentSentence = sentences[i];
                string[] splitSentence = currentSentence.Split(' ', ',', ':', ';');

                for (int j = 0; j < splitSentence.Length; j++)
                {
                    if (splitSentence[j] == word)
                    {
                        result.Append(currentSentence + '.');
                    }
                }
            }

            result.ToString();
            Console.WriteLine(result);
        }
    }
}
