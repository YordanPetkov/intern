using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Matrix
{
    class Matrix<T>
    {
        T[,] matrix;

        public Matrix(int n, int m)
        {
            matrix = new T[n, m];
        }

        public T this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }
        public static Matrix<T> operator+(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            try
            {
                if(matrix1.matrix.Length != matrix2.matrix.Length)
                {
                    throw new Exception("Operation addition cannot be performed.");
                }
            }
        }


    }
}
