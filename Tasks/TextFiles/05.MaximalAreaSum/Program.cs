using System;
using System.IO;

namespace _05.MaximalAreaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reader = new StreamReader("../../../matrix.txt");
                int n = int.Parse(reader.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] line = reader.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(line[j]);
                    }

                }

                reader.Close();
                int maxSum = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                        if(sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
                Console.WriteLine(maxSum);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
