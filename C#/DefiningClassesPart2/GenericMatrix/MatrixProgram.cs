using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class MatrixProgram
    {
        static void Main()
        {
            Matrix<int> a = new Matrix<int>(6, 6);
            Matrix<int> b = new Matrix<int>(6, 6);

            int value = 1;
            for (int col = 0; col < a.Cols; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < a.Rows; row++)
                    {
                        a[row, col] = value;
                        value++;
                    }
                }
                else
                {
                    for (int row = a.Rows - 1; row > -1; row--)
                    {
                        a[row, col] = value;
                        value++;
                    }
                }
            }

            Console.WriteLine("matrix a:\n{0}", a.ToString());
            Console.WriteLine();
            value = 1;
            for (int col = 0; col < b.Cols; col++)
            {
                for (int row = 0; row < b.Rows; row++)
                {
                    b[row, col] = value;
                    value++;
                }

            }
            Console.WriteLine("matrix b:\n{0}", b.ToString());

            Matrix<int> c = a + b;
            Console.WriteLine("matrix a + matrix b:\n{0}", c.ToString());
            Matrix<int> d = a - b;
            Console.WriteLine("matrix a - matrix b:\n{0}", d.ToString());
            Matrix<int> e = a * b;
            Console.WriteLine("matrix a * matrix b:\n{0}", e.ToString());



        }
    }
}
