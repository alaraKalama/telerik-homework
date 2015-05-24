using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.
namespace ReverseSentence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write some sentence:");
            string input = Console.ReadLine().Trim();
            
            string[] sentence = input.Split(' ').ToArray();
            StringBuilder reversed = new StringBuilder();

            for (int i = sentence.Length-1; i >= 0; i--)
            {
                reversed.Append(sentence[i] + ' ');
            }
            Console.WriteLine(reversed.ToString());
        }
    }
}
