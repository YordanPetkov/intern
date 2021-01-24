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
                int rowsMatrixA = matrixA.cells.GetLength(0);
                int colsMatrixA = matrixA.cells.GetLength(1);
                int rowsMatrixB = matrixB.cells.GetLength(0);
                int colsMatrixB = matrixB.cells.GetLength(1);
                if (colsMatrixA != rowsMatrixB)
                {
                    throw new Exception("Operation multiplication cannot be performed.");
                }

                else
                {
                    Matrix<T> matrixResult = new Matrix<T>(rowsMatrixA, colsMatrixB);

                    for (int i = 0; i < rowsMatrixA; i++)
                    {
                        for (int j = 0; j < colsMatrixB; j++)
                        {
                            dynamic cellIJ = 0;
                            for (int k = 0; k < colsMatrixA; k++)
                            {
                                dynamic tempA = matrixA[i, k];
                                dynamic tempB = matrixB[k, j];
                                dynamic result = Math.Abs(tempA * tempB);
                                cellIJ += result;
                            }
                            matrixResult[i, j] = cellIJ;

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

        public static bool operator true(Matrix<T> matrix)
        {
            bool isNonZero = true;
            for (int i = 0; i < matrix.cells.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.cells.GetLength(1); j++)
                {
                    dynamic cellIJ = matrix[i, j];
                    if(cellIJ == 0)
                    {
                        isNonZero = false;
                    }
                }
            }

            return isNonZero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isZero = true;
            for (int i = 0; i < matrix.cells.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.cells.GetLength(1); j++)
                {
                    dynamic cellIJ = matrix[i, j];
                    if (cellIJ == 0)
                    {
                        isZero = true;
                    }
                }
            }

            return isZero;
        }

        public override string ToString()
        {
            string printedMatrix = "";
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    printedMatrix += cells[i, j] + " ";
                }
                printedMatrix += "\n";
            }
            return printedMatrix;
        }
    }
}
