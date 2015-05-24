/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
 * the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. */

using System;

namespace MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverageOfN
    {
        static void Main()
        {
            Console.WriteLine("How many numbers you wish to enter:");
            int n = int.Parse(Console.ReadLine());
            int input;
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Eneter number {0}", i);
                input = int.Parse(Console.ReadLine());

                sum += input;
                if (input > max)
                {
                    max = input;
                }
                if (input < min)
                {
                    min = input;
                }
            }
            double average = (double)sum / (double)n;
            Console.WriteLine(" min: {0} \n max: {1} \n sum: {2} \n average: {3:0.00}", min, max, sum, average);
        }
    }
}
