using System;

namespace _07.Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double minNum = 0;
            double medNum = 0;
            double maxNum = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if(a >= b && a >= c)
            {
                maxNum = a;
                if (b >= c)
                {
                    medNum = b;
                    minNum = c;
                }
                if(c > b)
                {
                    medNum = c;
                    minNum = b;
                }
            }
            if(b > a && b >= c)
            {
                maxNum = b;
                if (a >= c)
                {
                    medNum = a;
                    minNum = c;
                }
                if (c > a)
                {
                    medNum = c;
                    minNum = a;
                }
            }
            if(c > a && c > b)
            {
                maxNum = c;
                if (a >= b)
                {
                    medNum = a;
                    minNum = b;
                }
                if (b > a)
                {
                    medNum = b;
                    minNum = a;
                }
            }
            Console.WriteLine("{0} {1} {2}", maxNum, medNum, minNum);
        }
        

    }
}
