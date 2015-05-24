using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------------------------------------------
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//a)	                   b)	                   c)	                   d)*
//   1 	5	9	13          1	8	9	16          7	11	14	16           1	12	11	10
//   2 	6	10	14          2	7	10	15          4	8	12	15           2 	13	16 	9
//   3 	7	11	15          3	6	11	14          2	5	9	13           3 	14	15	8
//   4 	8	12	16          4	5	12	13          1	3	6	10           4 	5	6	7

//------------------------------------------------------------------------------------------

namespace FillTheMatrix
{
    class FillMatrixX4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n (rows on colums for matrix)");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int value = 1;

            FillMatrixA(matrix, value, n);
            Console.WriteLine("A");
            Print(matrix, n);

            FillMatrixB(matrix, value, n);
            Console.WriteLine("B");
            Print(matrix, n);

            FillMatrixC(matrix, value, n);
            Console.WriteLine("C");
            Print(matrix, n);

            FillMatrixD(matrix, value, n);
            Console.WriteLine("D");
            Print(matrix, n);

        }

        static void Print (int[,] matrix, int n)
        {
            Console.WriteLine("Your matrix is:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 5} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
      
        //a).

        static void FillMatrixA(int[,] matrix, int value, int n)
        {

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = value;
                    value++;
                }

            }
        }

        //b).

        static void FillMatrixB(int[,] matrix, int value, int n)
        {
            value = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }
                else
                {
                    for (int row = n - 1; row > -1; row--)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }
            }
        }

        //c).

        static void FillMatrixC(int[,] matrix, int value, int n)
        {
            int max = n * n;
            int countRow = 1;
            int countCol = 0;
            value = 1;

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n; )
                {
                    matrix[row, col] = value;

                    if (value == max)
                    {
                        break;
                    }

                    else if (row == n - 1 && col != n - 1)
                    {
                        row -= countRow;
                        col -= countCol;
                        countRow++;
                        countCol++;
                    }

                    else if (row == n - 1 || col == n - 1)
                    {
                        countCol--;
                        countRow--;
                        col -= countCol;
                        row -= countRow;
                    }
                    else
                    {
                        row++;
                        col++;
                    }
                    value++;
                }
            }
        }

        //d).

        static void FillMatrixD(int[,] matrix, int value, int n)
        {
            value = 1;
            int max = n * n;
            int col = 0;
            int row = 0;
            int shift = 0;

            while (value <= max)
            {
               for (row = shift; row < n - shift; row++) //1
               {
                   col = shift;
                   matrix[row, col] = value;
                   value++;
               }

               for (col = shift + 1; col < n - shift; col++) //2
               {
                   row = (n - 1) - shift; 
                   matrix[row, col] = value;
                   value++;
               }

               for (row = (n - 2) - shift; row >= 0 + shift; row--) //3
               {
                   col = (n - 1) - shift;
                   matrix[row, col] = value;
                   value++;
               }

               for (col = (n - 2) - shift; col >= 1 + shift; col--) //4
               {
                   row = shift;
                   matrix[row, col] = value;
                   value++;
               }
               shift++;
            }
        }
    }
}
