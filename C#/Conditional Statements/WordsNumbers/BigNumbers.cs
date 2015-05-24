//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

namespace WordsNumbers
{
    class BigNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter real non-floating-point number:");
            int input = int.Parse(Console.ReadLine());
            int hundret = input / 100;
            int tempTen = input % 100;
            int ten = tempTen / 10;
            int digit = tempTen % 10;

            if (hundret > 0 && hundret < 10)
            {
                switch (hundret)
                {
                    case 1: Console.WriteLine("One hundred "); break;
                    case 2: Console.WriteLine("Two hundred "); break;
                    case 3: Console.WriteLine("Three hundred "); break;
                    case 4: Console.WriteLine("Four hundred "); break;
                    case 5: Console.WriteLine("Five hundred "); break;
                    case 6: Console.WriteLine("Six hundred "); break;
                    case 7: Console.WriteLine("Seven hundred "); break;
                    case 8: Console.WriteLine("Eight hundred "); break;
                    case 9: Console.WriteLine("Nine hundred "); break;
                    default: Console.WriteLine("Invalid input!"); break;
                }
                if ((ten == 0 && digit > 0) || ten == 1)
                {
                    Console.WriteLine("and ");
                }

                if (ten == 1)
                {
                    switch (digit)
                    {
                        case 0: Console.WriteLine("ten"); break;
                        case 1: Console.WriteLine("eleven"); break;
                        case 2: Console.WriteLine("twelve"); break;
                        case 3: Console.WriteLine("thirteen"); break;
                        case 4: Console.WriteLine("fourteen"); break;
                        case 5: Console.WriteLine("fifteen"); break;
                        case 6: Console.WriteLine("sixteen"); break;
                        case 7: Console.WriteLine("seventeen"); break;
                        case 8: Console.WriteLine("eighteen"); break;
                        case 9: Console.WriteLine("nineteen"); break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                if (ten > 1)
                {
                    switch (ten)
                    {
                        case 2: Console.WriteLine("twenty "); break;
                        case 3: Console.WriteLine("thirty "); break;
                        case 4: Console.WriteLine("fourty "); break;
                        case 5: Console.WriteLine("fifty "); break;
                        case 6: Console.WriteLine("sixty "); break;
                        case 7: Console.WriteLine("seventy "); break;
                        case 8: Console.WriteLine("eighty "); break;
                        case 9: Console.WriteLine("ninety "); break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                if (digit >= 1 && digit <= 9)
                {
                    switch (digit)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
            }
        }
    }
}
