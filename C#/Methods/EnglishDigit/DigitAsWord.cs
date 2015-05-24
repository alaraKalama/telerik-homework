using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word.

namespace EnglishDigit
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int input = int.Parse(Console.ReadLine());
            int lastDigit = GetLastDigit(input);
            Console.WriteLine("Last digit is {0}.", AsWord(lastDigit));
            
        }

        static int GetLastDigit (int input)
        {
            int lastDigit = input % 10;
            return lastDigit;
        }

        static string AsWord (int lastDigit)
        {
            string englishWord = " ";
            switch (lastDigit)
            {
                case 1: englishWord = "one"; break;
                case 2: englishWord = "two"; break;
                case 3: englishWord = "three"; break;
                case 4: englishWord = "four"; break;
                case 5: englishWord = "five"; break;
                case 6: englishWord = "six"; break;
                case 7: englishWord = "seven"; break;
                case 8: englishWord = "eight"; break;
                case 9: englishWord = "nine"; break;
                case 0: englishWord = "ten"; break;
                default: break;
            }
            return englishWord;
        }
    }
}

