using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//-------------------------------------------------------------------------------------------------------

namespace FindSumInArray
{
    class FindSum
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter sum:");
            int sum = int.Parse(Console.ReadLine());
           
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (currentSum != sum)
                {
                    currentSum = numbers[i];
                    startIndex = i;
                    counter = 0;

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (currentSum < sum)
                        {
                            currentSum += numbers[j];
                            counter++;
                        }
                        else if (currentSum >= sum)
                        {
                            break;
                        }
                    }
                }
                else if (currentSum == sum)
                {
                    endIndex = startIndex + counter;
                    break;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
			{
			 Console.Write("{0} ", numbers[i]);
			}
        }
    }
}
