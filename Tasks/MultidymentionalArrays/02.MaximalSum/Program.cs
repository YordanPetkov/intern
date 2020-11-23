using System;

namespace _2.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];
            int[,] matrixSums = new int[n, m];
            int maxSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);

                    for (int row = i - 2; row <= i; row++)
                    {
                        if(row < 0)
                        {
                            continue;
                        }

                        for (int column = j - 2; column <= j; column++)
                        {
                            if(column < 0)
                            {
                                continue;
                            }
                            matrixSums[row, column] += matrix[i, j];
                        }

                    }

                }

            }

            for (int i = 0; i < n - 2; i++)
            {

                for (int j = 0; j < m - 2; j++)
                {
                    if (matrixSums[i, j] > maxSum)
                    {
                        maxSum = matrixSums[i, j];
                    }
                }

            }

            Console.WriteLine(maxSum);
        }
    }
}
