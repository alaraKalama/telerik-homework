using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int min = 1;
            int max = 1000;

            Console.WriteLine("Enter number in the range 1 - 1000:");
            try
            {
                Console.WriteLine(ReadNumber(min, max));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Enter ten numbers in the range 1 - 1000 (in increasing order):");

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    int number = ReadNumber(min, max);
                    min = number;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int ReadNumber (int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number > end)
            {
                throw new FormatException();
            }
            return number;
        }
    }
}
