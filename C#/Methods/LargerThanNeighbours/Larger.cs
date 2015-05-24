using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers 
//is larger than its two neighbours (when such exist).

namespace LargerThanNeighbours
{
    public class Larger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements of array separated by space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Enter position of element to check:");
            int index = int.Parse(Console.ReadLine());

            bool isLarger = LargerThanNextDoor(numbers, index);
            Console.WriteLine("Element at position {0} is {1}.", index, numbers[index]);
            Console.WriteLine("{0} {1} greater than neighbour elements: {2} and {3}.", 
                numbers[index], isLarger ? "is" : "isn't", numbers[index - 1], numbers[index + 1]);

        }

        public static bool LargerThanNextDoor(int[] numbers, int index)
        {
            bool isLarger = false;

            if (numbers[index] > numbers[index - 1] && 
                numbers[index] > numbers[index + 1])
            {
                isLarger = true;
            }
            return isLarger;
        }
    }
}
