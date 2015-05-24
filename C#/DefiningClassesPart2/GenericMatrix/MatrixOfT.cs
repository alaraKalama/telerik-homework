using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class Matrix<T> 
    {
        private T[,] matrix;
        private int row;
        private int col;

        public Matrix(int rows, int cols)
        {
            this.row = rows;
            this.col = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.row; }
            private set 
            { 
                if (value < 1)
                {
                    throw new IndexOutOfRangeException("A matrix must have at least one row.");
                }

                this.row = value; 
            }
        }

        public int Cols
        {
            get { return this.col; }
            private set
            {
                if (value < 1)
                {
                    throw new IndexOutOfRangeException("A matrix must have at least one column.");
                }

                this.col = value;
            }
        }

        public T this [int row, int col]
        {
            get
            {
                if (row < 0 || row > this.Rows || 
                    col < 0 || col > this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row > this.Rows ||
                    col < 0 || col > this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new ArgumentException("Cannot add matrices with different number of rows or columns.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int r = 0; r < a.Rows; r++)
			{
                for (int c = 0; c < a.Cols; c++)
                {
                    result[r, c] = (dynamic)a[r, c] + b[r, c];
                }
			 
			}

            return result;

        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new ArgumentException("Cannot substract matrices with different number of rows or columns.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int r = 0; r < a.Rows; r++)
            {
                for (int c = 0; c < a.Cols; c++)
                {
                    result[r, c] = (dynamic)a[r, c] - b[r, c];
                }

            }

            return result;

        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows || a.Rows != b.Cols)
            {
                throw new ArgumentException("Cannot multiply matrices.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);

            for (int r = 0; r < a.Rows; r++)
            {
                for (int c = 0; c < a.Cols; c++)
                {
                    T value = (dynamic)0;
                    for (int i = 0; i < a.Cols; i++)
                    {
                        value += (dynamic)a[r, i] * b[i, c];
                    }
                    result[r, c] = value;
                }
            }

            return result;

        }

        public override string ToString()
        {
            StringBuilder matrix = new StringBuilder();
            for (int r = 0; r < this.Rows; r++)
            {
                for (int c = 0; c < this.Cols; c++)
                {
                    matrix.Append(this.matrix[r, c] + "\t");
                }
                matrix.AppendLine();
            }

            return matrix.ToString();
        }


    }
}
