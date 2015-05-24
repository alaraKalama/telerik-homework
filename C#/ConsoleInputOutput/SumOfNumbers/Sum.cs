//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note: You may need to use a for-loop.

using System;

namespace SumOfNumbers
{
    class Sum
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers in a line, separated by a space:", n);
            string line = Console.ReadLine();
            string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            if (n == numbers.Length)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += double.Parse(numbers[i]);
                }
                Console.WriteLine("The sum is {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
