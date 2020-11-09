using System;
using System.Runtime.ExceptionServices;

namespace _17.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[, ] spiral = new int[n, n];
            int curNum = 1;
            int dir = 0;
            int i = 0;
            int j = -1;
            int[] x = { 0, 1, 0, -1};
            int[] y = { 1, 0, -1, 0};
            Array.Clear(spiral, 0, n*n);

            while (curNum != n*n + 1)
            {
                i += x[dir];
                j += y[dir];
                spiral[i, j] = curNum;
                if(i + x[dir] > n-1 || i + x[dir] < 0 || j + y[dir] > n-1 || j + y[dir] < 0 || spiral[i + x[dir], j + y[dir]] != 0)
                {
                    if(dir == 3)
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

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ", spiral[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
