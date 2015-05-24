using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------------
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
//-------------------------------------------------------------------------------------------------------------

namespace BinarySearch
{
    class BinarySearchLessThanK
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of array separated by a space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(numbers);

            
            int index = Array.BinarySearch(numbers, k);

            while (index < 0)
            {
                k--;
            }

            Console.WriteLine("After you array is sorted");
            Console.WriteLine("{0} is at index [{1}]", k, index);
        }
    }
}
