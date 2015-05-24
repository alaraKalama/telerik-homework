using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace ParseTags
{
    class ToUpper
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string[] words = text.Split(' ').ToArray();
            string startTag = "<upcase>";
            string endTag = "</upcase>";
            StringBuilder upperText = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string upperWord = string.Empty;
                string currentWord = words[i];

                if (currentWord.Contains(startTag))
                {
                    for (int j = 0; j < currentWord.Length-1; j++)
                    {
                        if (currentWord[j] == '<' && currentWord[j + 1] != '/')
                        { 
                            currentWord = currentWord.Substring(8).ToUpper();
                        }
                        else if (currentWord[j] == '<' && currentWord[j + 1] == '/')
                        {
                            currentWord = currentWord.Remove(8);
                        }
                    }
                }
                else if (currentWord.Contains(endTag))
                {
                    currentWord = currentWord.Remove(9).ToUpper();
                }

                upperText.Append(currentWord + ' ');
            }

            Console.WriteLine(upperText.ToString());
        }

    }
}
