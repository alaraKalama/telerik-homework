using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

namespace SortingArray
{
    class SortMethod
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by a space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Enter index from which to search for max element:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last index to check for max number:");
            int stop = int.Parse(Console.ReadLine());

            int result = FindMaxInPortion(numbers, start, stop);
            Console.WriteLine("Result: {0}", result);
        }

        static int FindMaxInPortion(int[] numbers, int start, int stop)
        {
            int max = 0;
            if (start < 0 || stop > numbers.Length - 1)
            {
                Console.WriteLine("Invalid input! \n First index should be greater than zero or last should be lesser than the last element of the array");
            }
            else
            {
                for (int i = start + 1; i <= stop; i++)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    }
                }
            }
            return max;
        }

        static int[] Ascending (int[] numbers)
        {
            int start = 0;
            int stop = numbers.Length - 1;

            int max = FindMaxInPortion(numbers, start, stop);
            //and then max goes on last position, stop--, and so on my time is up
        }
    }
}
