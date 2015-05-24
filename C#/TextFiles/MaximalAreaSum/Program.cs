//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaximalAreaSum
{
    class Program
    {
        static void Main()
        {
            try
            {
                var read = new StreamReader(@"..\..\...\files\matrix.txt");
                int n = int.Parse(read.ReadLine());
                int maxChars = n * n;
                int[,] matrix = new int[n, n];

                for (int row = 0; row < n; row++)
                {
                    int[] currentLine = read.ReadLine().Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = currentLine[col];
                    }
                }

                int bestSum = int.MinValue;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int currentSum = matrix[row, col] +
                            matrix[row, col + 1] +
                            matrix[row + 1, col] +
                            matrix[row + 1, col + 1];
                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                        }
                    }
                }

                //var write = new StreamWriter(@"..\..\...\files\matrixResult.txt");
                string result = bestSum.ToString();
                File.WriteAllText(@"..\..\...\files\matrixResult.txt", result);
                Console.WriteLine("Ready.");
            }
            catch(FileLoadException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
