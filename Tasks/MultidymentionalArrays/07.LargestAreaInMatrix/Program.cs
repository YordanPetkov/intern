using System;

namespace _07.LargestAreaInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];
            int[,] areas = new int[n, m];
            int largestArea = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                    if(i > 0 && matrix[i - 1, j] == matrix[i, j])
                    {
                        areas[i, j] = areas[i - 1, j];
                    }
                    if(j > 0 && matrix[i, j - 1] == matrix[i, j])
                    {
                        areas[i, j] += areas[i, j - 1];
                        areas[i, j - 1] = areas[i, j] + 1;
                    }
                    areas[i, j]++;
                    if(areas[i, j] > largestArea)
                    {
                        largestArea = areas[i, j];
                    }
                }

            }

            Console.WriteLine(largestArea);
        }
    }
}
