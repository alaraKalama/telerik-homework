using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class CountWords
    {
        static void Main()
        {
            string text = @"Write a program that reads a string from the console and lists 
                        all different words in the string along with information how many times each word is found.";
            Console.WriteLine(text);
            string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            foreach(string word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word] += 1;
                }
            }

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
