using System;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            if(type == 'a')
            {
                int i = 0;
                int j = 0;

                for (int k = 1; k <= n*n; k++)
                {
                    matrix[i, j] = k;
                    i++;
                    if(i >= n)
                    {
                        i = 0;
                        j++;
                    }
                }

            }
            if(type == 'b')
            {
                int i = 0;
                int j = 0;
                bool dir = true; 

                for (int k = 1; k <= n*n; k++)
                {
                    matrix[i, j] = k;
                    if(dir)
                    {
                        if (i == n - 1)
                        {
                            j++;
                            dir = false;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            j++;
                            dir = true;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    
                }

            }
            if(type == 'c')
            {
                int curNum = 1;
                int i = n;
                int j = 0;

                while(curNum != n * n + 1)
                {
                    if(i == 0)
                    {
                        i = 0;
                        j++;
                    }
                    else
                    {
                        i--;
                        j = 0;
                    }
                    int row = i;
                    int column = j;
                    
                    while(row < n && column < n)
                    {
                        matrix[row, column] = curNum;
                        row++;
                        column++;
                        curNum++;
                    }

                }
            }
            if(type == 'd')
            {
                int curNum = 1;
                int dir = 0;
                int i = -1;
                int j = 0;
                int[] x = { 1, 0, -1, 0 };
                int[] y = { 0, 1, 0, -1 };

                while (curNum != n * n + 1)
                {
                    i += x[dir];
                    j += y[dir];
                    matrix[i, j] = curNum;
                    if (i + x[dir] > n - 1 || i + x[dir] < 0 || j + y[dir] > n - 1 || j + y[dir] < 0 || matrix[i + x[dir], j + y[dir]] != 0)
                    {
                        if (dir == 3)
                        {
                            dir = 0;
                        }
                        else
                        {
                            dir++;
                        }
                    }
                    curNum++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
