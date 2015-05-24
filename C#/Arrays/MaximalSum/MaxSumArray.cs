using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
// Write a program that finds the sequence of maximal sum in given array.
// Example:
// input	                                   result
// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	           2, -1, 6, 4
// Can you do it with only one loop (with single scan through the elements of the array)?
//-------------------------------------------------------------------------------------------------------

namespace MaximalSum
{
    class MaxSumArray
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentSum = numbers[0];
            int maxSum = numbers[0];
            int start = 0;
            int end = 0;
            int tempStart = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (currentSum <= 0)
                {
                    tempStart = i;
                    currentSum = 0;
                }

                currentSum += numbers[i];

                if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        start = tempStart;
                        end = i;
                    }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
