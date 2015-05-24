//Write a program that finds the maximal sequence of equal elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaxSeq
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxSeq = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > maxSeq)
                        {
                            maxSeq = counter;
                            element = numbers[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int a = 1; a <= maxSeq; a++)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}
