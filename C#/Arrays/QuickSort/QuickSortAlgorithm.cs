using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=ywWBy6J5gz8


namespace QuickSort
{
    class QuickSortAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            QuickSort(numbers, 0, numbers.Length - 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

        }

        static void QuickSort(int[] numbers, int start, int end)
        {
            if (start < end)
            {
                int pivot = numbers[end];
                int wallIndex = start;

                for (int i = start; i < end; i++)
                {
                    if (numbers[i] <= pivot) //swap
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[wallIndex];
                        numbers[wallIndex] = temp;

                        wallIndex++;
                    }

                }


                numbers[end] = numbers[wallIndex];
                numbers[wallIndex] = pivot;

                QuickSort(numbers, wallIndex + 1, end);
                QuickSort(numbers, start, wallIndex - 1);
            }
        }
    }
}
