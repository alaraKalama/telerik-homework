//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//and prints a matrix like in the examples below. Use two nested loops.
/*n = 2   matrix      n = 3   matrix      n = 4   matrix
          1 2                 1 2 3               1 2 3 4
          2 3                 2 3 4               2 3 4 5
                              3 4 5               3 4 5 6
                                                  4 5 6 7 */
using System;

namespace MatrixOfNumbers
{
    class Matrix
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number (max 20):");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <=20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0, 5}", i + j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Number should be (1 ≤ n ≤ 20)");
            }
        }
    }
}
