using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
// smallest from the rest, move it at the second position, etc.
//-------------------------------------------------------------------------------------------------------

namespace SelectionSort
{
    class SortArray
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (int value in numbers)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
