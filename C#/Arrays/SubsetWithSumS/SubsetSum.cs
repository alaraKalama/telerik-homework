using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//--------------------------------------------------------------------------------------------------

namespace SubsetWithSumS
{
    class SubsetSum
    {
        static void Main()

            //This is not working
        {
            Console.WriteLine("Enter elements of  an array to initialize it(in a single line, separated by space):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter sum:");
            int sum = int.Parse(Console.ReadLine());

            Array.Sort(numbers);

            int tempSum = 0;
            int testSum = 0;
            bool yes = false;

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                tempSum += numbers[i];
                if (tempSum == sum)
                {
                    yes = true;
                    break;
                }
                else if (tempSum > sum)
                {
                    tempSum -= numbers[i];
                    continue;
                }
            }

            Console.WriteLine("{0}", yes ? "yes":"no");
        }
    }
}
