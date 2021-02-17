using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using System;

namespace MatricaTests
{
    [TestClass]
    public class WalkInMatricaTests
    {
        [TestMethod]
        public void ChangeDirection_WithValidDirections_UpdateDirection()
        {
            int[] startDirectionX = {1, 1, 1, 0, -1, -1, -1, 0};
            int[] startDirectionY = {1, 0, -1, -1, -1, 0, 1, 1};
            int[] expectedDirectionX = {1, 1, 0, -1, -1, -1, 0, 1};
            int[] expectedDirectionY = {0, -1, -1, -1, 0, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                WalkInMatrica.ChangeDirection(ref startDirectionX[i], ref startDirectionY[i]);
            }

            bool result = true;
            for (int i = 0; i < 8; i++)
            {
                if((startDirectionX[i] == expectedDirectionX[i] && startDirectionY[i] == expectedDirectionY[i]) == false)
                {
                    result = false;
                    break;
                }
            }
            
            Assert.IsTrue(result, "Directions not updated correctly");
        }

        [TestMethod]
        public void ChangeDirection_WhenDirectionXIsInvalid_ShouldThrowArgumentOutOfRange()
        {
            int startDirectionX = -2;
            int startDirectionY = 0;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.ChangeDirection(ref startDirectionX,ref startDirectionY));
        }

        [TestMethod]
        public void ChangeDirection_WhenDirectionYIsInvalid_ShouldThrowArgumentOutOfRange()
        {
            int startDirectionX = 1;
            int startDirectionY = 3;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.ChangeDirection(ref startDirectionX, ref startDirectionY));
        }

        [TestMethod]
        public void CheckForPath_WithValidCoordinates_ShouldReturnTrue()
        {
            int[,] matrix =
                {
                    {1, 9, 0, 0},
                    {4, 3, 10, 0},
                    {5, 6, 7, 8},
                    {0, 0, 0, 0}
                };
            int row = 1;
            int column = 1;

            bool result = WalkInMatrica.CheckForPath(matrix, row, column);

            Assert.IsTrue(result, "Cannot find existing path.");
        }

        [TestMethod]
        public void CheckForPath_WithValidCoordinates_ShouldReturnFalse()
        {
            int[,] matrix =
                {
                    {1, 9, 0, 0},
                    {4, 3, 10, 0},
                    {5, 6, 7, 8},
                    {0, 0, 0, 0}
                };
            int row = 1;
            int column = 0;

            bool result = WalkInMatrica.CheckForPath(matrix, row, column);

            Assert.IsTrue(result == false, "Cannot find existing path.");
        }

        [TestMethod]
        public void CheckForPath_WithInvalidMatrix_ShouldThrowArgumentNullException()
        {
            int[,] matrix = null;
            int row = 0;
            int column = 0;

            Assert.ThrowsException<ArgumentNullException>(() => WalkInMatrica.CheckForPath(matrix, row, column));
        }

        [TestMethod]
        public void CheckForPath_WithInvalidRow_ShouldThrowArgumentOutOfRange()
        {
            int[,] matrix =
                {
                    {1, 9, 0, 0},
                    {4, 3, 10, 0},
                    {5, 6, 7, 8},
                    {0, 0, 0, 0}
                };
            int row = 4;
            int column = 0;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.CheckForPath(matrix, row, column));
        }

        [TestMethod]
        public void CheckForPath_WithInvalidColumn_ShouldThrowArgumentOutOfRange()
        {
            int[,] matrix =
                {
                    {1, 9, 0, 0},
                    {4, 3, 10, 0},
                    {5, 6, 7, 8},
                    {0, 0, 0, 0}
                };
            int row = 2;
            int column = 4;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.CheckForPath(matrix, row, column));
        }

        [TestMethod]
        public void FindCell_WithValidMatrix_ShouldReturnTrue()
        {
            int[,] matrix =
                {
                    {1, 9, 11, 12},
                    {4, 3, 10, 13},
                    {5, 6, 7, 8},
                    {14, 0, 0, 0}
                };
            int expectedRow = 3;
            int expectedColumn = 1;

            bool result = WalkInMatrica.FindCell(matrix, out int row, out int column);

            Assert.IsTrue((result && row == expectedRow && column == expectedColumn), "Cannot find existing cell.");
        }

        [TestMethod]
        public void FindCell_WithValidMatrix_ShouldReturnFalse()
        {
            int[,] matrix =
                {
                    {1, 9, 11, 12},
                    {4, 3, 10, 13},
                    {5, 6, 7, 8},
                    {14, 15, 16, 17}
                };
            int expectedRow = -1;
            int expectedColumn = -1;

            bool result = WalkInMatrica.FindCell(matrix, out int row, out int column);

            Assert.IsTrue((!result && row == expectedRow && column == expectedColumn), "Should not find cell.");
        }

        [TestMethod]
        public void FindCell_WithInvalidMatrix_ShouldThrowArgumentNullException()
        {
            int[,] matrix = null;

            Assert.ThrowsException<ArgumentNullException>(() => WalkInMatrica.FindCell(matrix, out int row, out int column));
        }
        [TestMethod]
        public void FillMatrix_WithValidArguments_ShouldFillHalfMatrix()
        {
            int[,] matrix =
                {
                    {0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0}
                };
            int[,] expectedMatrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = 0;
            int column = 0;
            int matrixSize = matrix.GetLength(0);
            int currentNumber = 1;

            WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber);

            bool isExpectedMatrix = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] != expectedMatrix[i, j])
                    {
                        isExpectedMatrix = false;
                        goto NotSameMatrix;
                    }
                }
            }

            NotSameMatrix:
            Assert.IsTrue(isExpectedMatrix, "Matrix is not fill correct.");
        }

        [TestMethod]
        public void FillMatrix_WithValidArguments_ShouldFillWholeMatrix()
        {
            int[,] matrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int [,] expectedMatrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 23, 3, 20, 18},
                    {10, 25, 24, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = 2;
            int column = 1;
            int matrixSize = matrix.GetLength(0);
            int currentNumber = 23;

            WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber);

            bool isExpectedMatrix = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != expectedMatrix[i, j])
                    {
                        isExpectedMatrix = false;
                        goto NotSameMatrix;
                    }
                }
            }

        NotSameMatrix:
            Assert.IsTrue(isExpectedMatrix, "Matrix is not fill correct.");
        }

        [TestMethod]
        public void FillMatrix_WithInvalidMatrix_ShouldThrowArgumentNullException()
        {
            int[,] matrix = null;
            int row = 2;
            int column = 1;
            int matrixSize = 0;
            int currentNumber = 23;

            Assert.ThrowsException<ArgumentNullException>(() => WalkInMatrica.FillMatrix(matrix,matrixSize,row,column,ref currentNumber));
        }

        [TestMethod]
        public void FillMatrix_WithInvalidMatrixSize_ShouldThrowArgumentOutOfRangeException()
        {
            int[,] matrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = 2;
            int column = 1;
            int matrixSize = 6;
            int currentNumber = 23;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber));
        }

        [TestMethod]
        public void FillMatrix_WithInvalidRow_ShouldThrowArgumentOutOfRangeException()
        {
            int[,] matrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = -1;
            int column = 1;
            int matrixSize = matrix.GetLength(0);
            int currentNumber = 23;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber));
        }

        [TestMethod]
        public void FillMatrix_WithInvalidColumn_ShouldThrowArgumentOutOfRangeException()
        {
            int[,] matrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = 2;
            int column = 5;
            int matrixSize = matrix.GetLength(0);
            int currentNumber = 23;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber));
        }

        [TestMethod]
        public void FillMatrix_WithInvalidCurrentNumber_ShouldThrowArgumentOutOfRangeException()
        {
            int[,] matrix =
                {
                    {1, 13, 14, 15, 16},
                    {12, 2, 21, 22, 17},
                    {11, 0, 3, 20, 18},
                    {10, 0, 0, 4, 19},
                    {9, 8, 7, 6, 5}
                };
            int row = 2;
            int column = 1;
            int matrixSize = matrix.GetLength(0);
            int currentNumber = 26;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => WalkInMatrica.FillMatrix(matrix, matrixSize, row, column, ref currentNumber));
        }
    }
}
