using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LargerThanNeighbours;

//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

namespace FirstLargerThanNeighbours
{
    class FirstLarger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements of array separated by space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        static int First (int[] numbers)
        {
            int first = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                bool first = LargerThanNeighbours(number, numbers[index]);
            }
        }
    }
}
