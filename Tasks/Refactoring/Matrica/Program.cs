using System;

namespace Task3
{
    class WalkInMatrica
    {

        static void ChangeDirection(ref int directionX, ref int directionY)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == directionX && dirY[count] == directionY)
                {
                    currentDirection = count;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                directionX = dirX[0];
                directionY = dirY[0];
                return;
            }

            directionX = dirX[currentDirection + 1];
            directionY = dirY[currentDirection + 1];
        }

        static bool CheckForPath(int[,] matrix, int row, int column)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (row + dirX[i] >= matrix.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (column + dirY[i] >= matrix.GetLength(0) || column + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + dirX[i], column + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindCell(int[,] matrix, out int row, out int column)
        {
            row = 0;
            column = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row = i;
                        column = j;
                        return;
                    }
                }
            }
        }

        static void FillMatrix(int[,] matrix, int matrixSize, int row, int column,ref int currentNumber)
        {
            int directionX = 1;
            int directionY = 1;

            while (true)
            {
                matrix[row, column] = currentNumber;

                if (!CheckForPath(matrix, row, column))
                {
                    currentNumber++;
                    break;
                }

                if (row + directionX >= matrixSize || row + directionX < 0
                        || column + directionY >= matrixSize || column + directionY < 0
                        || matrix[row + directionX, column + directionY] != 0)
                {
                    while ((row + directionX >= matrixSize || row + directionX < 0
                            || column + directionY >= matrixSize || column + directionY < 0
                            || matrix[row + directionX, column + directionY] != 0))
                    {
                        ChangeDirection(ref directionX, ref directionY);
                    }
                }

                row += directionX;
                column += directionY;
                currentNumber++;
            }
        }

        static void PrintMatrix(int[,] matrix, int matrixSize)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    int countSymbols = (matrixSize * matrixSize).ToString().Length;
                    string formatString = String.Concat("{0,", countSymbols + 1, "}");
                    Console.Write(formatString, matrix[i, j], countSymbols);
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a positive number " );
            string input = Console.ReadLine();
            int matrixSize;

            while ( !int.TryParse( input, out matrixSize) || matrixSize < 0 || matrixSize > 100 )
            {
                Console.WriteLine( "You haven't entered a correct positive number" );
                input = Console.ReadLine();
            }

            int[,] matrix = new int[matrixSize, matrixSize];
            int row = 0;
            int column = 0;
            int currentNumber = 1;

            while(currentNumber < matrixSize * matrixSize)
            {
                FillMatrix(matrix, matrixSize, row, column, ref currentNumber);
                FindCell(matrix, out row, out column);
            }

            PrintMatrix(matrix, matrixSize);
        }
    }
}
