using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
//Write a program that finds the maximal increasing sequence in an array.
//-------------------------------------------------------------------------------------------------------

namespace tempMaxIncreasingSequence
{
    class tempMaxIncreasingSeq
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = 0;
            int tempMax = 0;
            int max = 0;
            int counter = 0;
            int seqLenght = 0;
            int i = 0;

            for (int j = 1; j < numbers.Length; j++)
            {
                i = j - 1;
                if (numbers[j] - numbers[i] == 1)
                {
                    tempMax = numbers[j];
                    counter++;
                    if (counter > seqLenght)
                    {
                        seqLenght = counter;
                        max = tempMax;
                    }
                }
                else
                {
                    counter = 0;
                    tempMax = 0;
                }
            }
            
            min = tempMax - seqLenght;
            int range = seqLenght + 1;
            int[] result = Enumerable.Range(min, range).ToArray();

            foreach (int number in result)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
