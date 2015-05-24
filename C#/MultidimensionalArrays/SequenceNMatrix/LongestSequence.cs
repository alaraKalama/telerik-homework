using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
//elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

//Example:

/*     matrix	       result		             matrix      	result
 
    ha	fifi ho	hi     ha ha ha                s 	qq	s       s s s
    fo	ha	hi	xx                             pp	pp	s
    xxx	ho	ha	xx                             pp	qq	s
 
 */

//-------------------------------------------------------------------------------------------------------

namespace SequenceNMatrix
{
    class LongestSequence
    {
        static void Main()
        {
            //enter number of rows and columns
            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];

            //assign values for each element
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.WriteLine("Matrix[{0},{1}]:", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            //print
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0, 5} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            int count = 1;
            int bestCount = 0;
            string winner = null;
            string currentWinner = null;

            #region horizont

            for (int row = 0; row < n - 1; row++)
            {
                count = 1;
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                        currentWinner = matrix[row, col];
                        if (bestCount < count)
                        {
                            bestCount = count;
                            winner = currentWinner;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            #endregion

            #region verticals
            
            for (int col = 0; col < m - 1; col++)
            {
                count = 1;
                for (int row = 0; row < n - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                        currentWinner = matrix[row, col];
                        if (bestCount < count)
                        {
                            bestCount = count;
                            winner = currentWinner;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
#endregion

            #region DiagonAli

            //check fucking diagonals

            //from left to right

            count = 1;
            for (int row = 0, col = 0; row < n - 1 && col < m - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                    currentWinner = matrix[row, col];
                    if (count > bestCount)
                    {
                        bestCount = count;
                        winner = currentWinner;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            //from right to left
            count = 1;
            for (int row = 0, col = m - 1; row < n - 1 && col >=1; row++, col--)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    count++;
                    currentWinner = matrix[row, col];
                    if (count > bestCount)
                    {
                        bestCount = count;
                        winner = currentWinner;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            #endregion

            PrintResult(bestCount, winner);
        }


        static void PrintResult(int bestCount, string winner)
        {
            Console.WriteLine("RESULT:");
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write("{0} ", winner);
            }
        }
    }
}
