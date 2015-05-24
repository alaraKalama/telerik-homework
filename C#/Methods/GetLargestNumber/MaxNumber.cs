using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------------------------------------------------------------
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
//------------------------------------------------------------------------------------------------------------------

namespace GetLargestNumber
{
    class MaxNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int input3 = int.Parse(Console.ReadLine());

            int result = GetMax(GetMax(input1, input2), input3);

            Console.WriteLine("Max is {0}", result);
        }

        static int GetMax (int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else if (b > a)
            {
                max = b;
            }

            return max;
        }

    }
}
