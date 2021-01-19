using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _08.Matrix
{
    class Matrix<T>
    {
        T[,] cells;

        public Matrix(int n, int m)
        {
            cells = new T[n, m];
        }

        public T this[int row, int col]
        {
            get { return cells[row, col]; }
            set { cells[row, col] = value; }
        }
        public static Matrix<T> operator+(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            try
            {
                if(matrixA.cells.GetLength(0) != matrixB.cells.GetLength(0) || matrixA.cells.GetLength(1) != matrixB.cells.GetLength(1))
                {
                    throw new Exception("Operation addition cannot be performed.");
                }

                else
                {
                    int rows = matrixA.cells.GetLength(0);
                    int cols = matrixA.cells.GetLength(1);
                    Matrix<T> matrixSum = new Matrix<T> (rows, cols);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dynamic tempA = matrixA[i, j];
                            dynamic tempB = matrixB[i, j];
                            dynamic result = tempA + tempB;
                            matrixSum[i, j] = result;
                        }
                    }

                    return matrixSum;
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return null;
        }

        public static Matrix<T> operator -(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            try
            {
                if (matrixA.cells.GetLength(0) != matrixB.cells.GetLength(0) || matrixA.cells.GetLength(1) != matrixB.cells.GetLength(1))
                {
                    throw new Exception("Operation subtraction cannot be performed.");
                }

                else
                {
                    int rows = matrixA.cells.GetLength(0);
                    int cols = matrixA.cells.GetLength(1);
                    Matrix<T> matrixResult = new Matrix<T>(rows, cols);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dynamic tempA = matrixA[i, j];
                            dynamic tempB = matrixB[i, j];
                            dynamic result = Math.Abs(tempA - tempB);
                            matrixResult[i, j] = result;
                        }
                    }

                    return matrixResult;
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return null;
        }

        public static Matrix<T> operator *(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            try
            {
                if (matrixA.cells.GetLength(1) != matrixB.cells.GetLength(0))
                {
                    throw new Exception("Operation multiplication cannot be performed.");
                }

                else
                {
                    int rows = matrixA.cells.GetLength(0);
                    int cols = matrixB.cells.GetLength(1);
                    Matrix<T> matrixResult = new Matrix<T>(rows, cols);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dynamic tempA = matrixA[i, j];
                            dynamic tempB = matrixB[i, j];
                            dynamic result = Math.Abs(tempA - tempB);
                            matrixResult[i, j] = result;
                        }
                    }

                    return matrixResult;
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return null;
        }
    }
}
