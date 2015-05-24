using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class CountLetters
    {
        static void Main()
        {
            string text = @"Write a program that reads a string from the console and prints all different letters
                            in the string along with information how many times each letter is found.";
            Console.WriteLine(text);

            SortedDictionary<char, int> resultDict = new SortedDictionary<char, int>();
            
            int countAppearance = 0;

            foreach(char letter in text)
            {
                if (char.IsLetter(letter) && !resultDict.ContainsKey(letter))
                {
                    resultDict.Add(letter, 1);
                }
                else if (char.IsLetter(letter) && resultDict.ContainsKey(letter))
                {
                    resultDict[letter] += 1;
                }
            }

            foreach (KeyValuePair<char, int> pair in resultDict)
            {
                Console.WriteLine(pair);
            }

        }
    }
}
