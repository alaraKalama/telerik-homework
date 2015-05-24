using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace AppearanceCount
{
    class CountAppearanceMethod
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by a space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Enter number(to count it's appearance):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearance(numbers, n));
        }

        static int CountAppearance(int[] numbers,int n)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    counter++;
                }
            }
                return counter;
        }
    }
}
