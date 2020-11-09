using System;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddProduct = 1;
            int evenProduct = 1;
            var input = Console.ReadLine();
            var data = input.Split(' ');

            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                {
                    oddProduct *= int.Parse(data[i-1]);
                }

                else
                {
                    evenProduct *= int.Parse(data[i-1]);
                }
            }

            if(oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}",oddProduct, evenProduct);
            }
        }
    }
}
