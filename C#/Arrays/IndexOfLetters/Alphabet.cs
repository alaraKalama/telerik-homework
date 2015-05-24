using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Alphabet
    {
        static void Main()
        {
            char[] alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();

            string input = Console.ReadLine();
            
            foreach (char c in input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == c)
                    {
                        Console.WriteLine("{0} = {1} element in array", alphabet[i], i);
                        Console.WriteLine("{0} = {1} letter in the alphabet", alphabet[i], i+1);
                    }
                }
            }
            
        }
    }
}
