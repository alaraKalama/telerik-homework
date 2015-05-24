//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

namespace SumOf5Numbers
{
    class OneLine
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers in one line, separated by a space:");
            string line = Console.ReadLine();
            //This [] is an array. An array have number of elements (in our case we need it to have 5 elements - each to hold one
            //of the given numbers)
            //But arrays can hold anything(I think) so first we have to remove the empty spaces between the numbers.
            string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Than asign a double variable for the sum.
            double sum = 0;

            //The program should work only if the input numbers are five - the number of elements of an array is it's lenght.
            if (numbers.Length == 5)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += double.Parse(numbers[i]);
                }
                Console.WriteLine("The sum is {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
