using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------
// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
//--------------------------------------------------------------------------------------------------------------------------

namespace BinarySearch
{
    class SearchBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter sorted elements of an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] tempNumbers = (int[])numbers.Clone();
            Array.Sort(numbers);

            Console.WriteLine("Enter target:");
            int target = int.Parse(Console.ReadLine());

            int middleElement = numbers.Length / 2;
            int middleLenght = middleElement / 2;

            while (numbers[middleElement] != target)
            {
                if (numbers[middleElement] > target)
                {
                    middleElement -= middleLenght;
                    middleLenght /= 2;
                }
                else if (numbers[middleElement] < target)
                {
                    middleElement += middleLenght;
                    middleLenght /= 2;
                }
            }

            Console.WriteLine(middleElement);
           
        }
    }
}
