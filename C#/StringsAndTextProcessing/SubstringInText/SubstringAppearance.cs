using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInText
{
    class SubstringAppearance
    {
        static void Main()
        {
            Console.WriteLine("The text is:");
            string text = @"We are living in an yellow submarine. We don't have anything else. 
                            inside the submarine is very tight. So we are drinking all the day.
                            We will move out of it in 5 days.";
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Enter substring:");
            string sub = Console.ReadLine();
            Console.WriteLine("{0} appears {1} times in the text", sub, CountSubstrings(text, sub));

        }

        static int CountSubstrings (string text, string sub)
        {
            int subLenght = sub.Length;
            int count = 0;
            for (int i = 0; i < text.Length - subLenght + 1; i++)
            {
                if (text.Substring(i, subLenght) == sub)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
