using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that
//has maximal sum of its elements.
//-------------------------------------------------------------------------------------------------------

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            int maxRow = n - 2;
            int maxCol = m - 2;
            int bestSum = int.MinValue;
            int bestStart = 0;
            int bestRow = 0;
            int bestCol = 0;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.WriteLine("matrix [{0},{1}]=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Your matrix is:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 5} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            for (int row = 0; row < n; row++)
            {
                if (row >= maxRow)
                {
                    continue;
                }

               for (int col = 0; col < m; col++)
               {
                   if (col >= maxCol)
                   {
                       continue;
                   }

                   int newSum =
                                  matrix[row, col] +
                                  matrix[row, col + 1] +
                                  matrix[row, col + 2] +
                                  matrix[row + 1, col] +
                                  matrix[row + 1, col + 1] +
                                  matrix[row + 1, col + 2] +
                                  matrix[row + 2, col] +
                                  matrix[row + 2, col + 1] +
                                  matrix[row + 2, col + 2];

                   if (bestSum <= newSum)
                   {
                       bestSum = newSum;
                       bestStart = matrix[row, col];
                       bestRow = row;
                       bestCol = col;
                   }
               }
            }

            Console.WriteLine();
            Console.WriteLine("3x3 cube with best sum:");
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0, 5} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
