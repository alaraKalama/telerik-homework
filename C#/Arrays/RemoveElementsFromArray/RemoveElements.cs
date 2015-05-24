using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{

    //This is not working
    class RemoveElements
    {
        static void Main()
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    numbers[i + 1] = 0;
                }
            }
        }
    }
}
