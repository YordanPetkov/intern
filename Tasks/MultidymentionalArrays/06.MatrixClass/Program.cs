using System;

namespace _06.MatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height and width of first matrix :");
            string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int m1 = int.Parse(input[1]);
            int[,] array1 = new int[n1, m1];
            Console.WriteLine("Input first matrix :");

            for (int i = 0; i < n1; i++)
            {
                input = Console.ReadLine().Split();

                for (int j = 0; j < m1; j++)
                {
                    array1[i, j] = int.Parse(input[j]);
                }

            }

            Console.WriteLine("Input height and width of second matrix :");
            input = Console.ReadLine().Split();
            int n2 = int.Parse(input[0]);
            int m2 = int.Parse(input[1]);
            int[,] array2 = new int[n2, m2];
            Console.WriteLine("Input second matrix :");

            for (int i = 0; i < n2; i++)
            {
                input = Console.ReadLine().Split();

                for (int j = 0; j < m2; j++)
                {
                    array2[i, j] = int.Parse(input[j]);
                }

            }

            Matrix matrix1 = new Matrix(array1);
            Matrix matrix2 = new Matrix(array2);
            Matrix matrixAdd = matrix1 + matrix2;
            Matrix matrixSub = matrix1 - matrix2;
            Matrix matrixMult = matrix1 * matrix2;
            Console.WriteLine("First matrix + second matrix : \n{0}", matrixAdd.ToString());
            Console.WriteLine("First matrix - second matrix : \n{0}", matrixSub.ToString());
            Console.WriteLine("First matrix * second matrix : \n{0}", matrixMult.ToString());
        }
    }

    class Matrix
    {
        private int[,] matrix;
        private int height;
        private int width;

        public Matrix(int[,] nums)
        {
            matrix = nums;
            height = nums.GetLength(0);
            width = nums.GetLength(1);
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    result += matrix[i, j].ToString();
                    result += " ";
                }

                result += '\n';
            }

            return result;
        }

        public int Get(int i, int j)
        {
            return matrix[i, j];
        }

        public void Set(int i, int j, int value)
        {
            matrix[i, j] = value;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(new int[Math.Max(a.height, b.height), Math.Max(a.width, b.width)]);

            for (int i = 0; i < c.height; i++)
            {

                for (int j = 0; j < c.width; j++)
                {
                    if (i < a.height && j < a.width)
                    {
                        c.matrix[i, j] += a.matrix[i, j];
                    }
                    if (i < b.height && j < b.width)
                    {
                        c.matrix[i, j] += b.matrix[i, j];
                    }
                }

            }

            return c;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(new int[Math.Max(a.height, b.height), Math.Max(a.width, b.width)]);

            for (int i = 0; i < c.height; i++)
            {

                for (int j = 0; j < c.width; j++)
                {
                    if (i < a.height && j < a.width)
                    {
                        c.matrix[i, j] += a.matrix[i, j];
                    }
                    if (i < b.height && j < b.width)
                    {
                        c.matrix[i, j] -= b.matrix[i, j];
                    }
                }

            }

            return c;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if(a.height != b.width || a.width != b.height)
            {
                return new Matrix(new int[Math.Max(a.height, b.height), Math.Max(a.width, b.width)]);
            }
            Matrix c = new Matrix(new int[a.height, b.width]);

            for (int i = 0; i < c.height; i++)
            {

                for (int j = 0; j < c.width; j++)
                {

                    for (int columnA = 0, rowB = 0; columnA < a.width || rowB < b.height; columnA++,rowB++)
                    {
                        c.matrix[i, j] += a.matrix[i, columnA] * b.matrix[rowB, j];
                    }

                }

            }

            return c;
        }

    }

    
}
