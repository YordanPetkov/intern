using System;

namespace _08.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrixA = new Matrix<int>(2, 2);
            Matrix<int> matrixB = new Matrix<int>(2, 2);
            matrixA[0, 0] = 4;
            matrixA[0, 1] = 3;
            matrixA[1, 0] = 2;
            matrixA[1, 1] = 5;
            matrixB[0, 0] = 1;
            matrixB[0, 1] = 2;
            matrixB[1, 0] = 1;
            matrixB[1, 1] = 3;
            Matrix<int> sumMatrix = matrixA + matrixB;
            Matrix<int> resultSubtractionMatrix = matrixA - matrixB;
            Matrix<int> productMatrix = matrixA * matrixB;
            Console.WriteLine(sumMatrix.ToString());
            Console.WriteLine(resultSubtractionMatrix.ToString()); 
            Console.WriteLine(productMatrix.ToString());
            Console.WriteLine("Version of matrix A: {0}", matrixA.Version);
        }
    }
}
