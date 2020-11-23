using System;

namespace _03.SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];
            int[][,] sequences = new int[3][,]
            {
                new int[n, m],
                new int[n, m],
                new int[n, m]
            };
            int maxSeq = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                    if(j - 1 >= 0 && matrix[i, j - 1] == matrix[i, j])
                    {
                        sequences[0][i, j] = sequences[0][i, j - 1] + 1;
                    }
                    else
                    {
                        sequences[0][i, j] = 1;
                    }
                    if (i - 1 >= 0 && matrix[i - 1, j] == matrix[i, j])
                    {
                        sequences[1][i, j] = sequences[1][i - 1, j] + 1;
                    }
                    else
                    {
                        sequences[1][i, j] = 1;
                    }
                    if (j - 1 >= 0 && i - 1 >= 0 && matrix[i - 1, j - 1] == matrix[i, j])
                    {
                        sequences[2][i, j] = sequences[2][i - 1, j - 1] + 1;
                    }
                    else
                    {
                        sequences[2][i, j] = 1;
                    }

                    for (int k = 0; k < 3; k++)
                    {
                        if (sequences[k][i, j] > maxSeq)
                        {
                            maxSeq = sequences[k][i, j];
                        }
                    }
                    
                }

            }

            Console.WriteLine(maxSeq);
        }
    }
}