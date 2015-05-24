using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class Program
    {
        static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            Console.WriteLine(text);
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }).ToArray();

            SortedSet<string> sort = new SortedSet<string>();
            
            foreach(string word in words)
            {
                sort.Add(word);
            }
            Console.WriteLine();
            Console.WriteLine("WORDS IN ALPHABETICAL ORDER:");
            Console.WriteLine();
            foreach(string val in sort)
            {
                Console.WriteLine(val);
            }
        }
    }
}
