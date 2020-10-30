using System;

namespace _06.FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //int abcd;
            //int a;
            //int b;
            //int c;
            //int d;
            //abcd = int.Parse(Console.ReadLine());
            //a = abcd / 1000;
            //b = abcd % 1000 / 100;
            //c = abcd % 100 / 10;
            //d = abcd % 10;

            //int sum;
            //int dcba;
            //int dabc;
            //int acbd;
            //sum = a + b + c + d;
            //dcba = d * 1000 + c * 100 + b * 10 + a;
            //dabc = d * 1000 + a * 100 + b * 10 + c;
            //acbd = a * 1000 + c * 100 + b * 10 + d;

            //Console.WriteLine(sum);
            //Console.WriteLine(dcba);
            //Console.WriteLine(dabc);
            //Console.WriteLine(acbd);


            string abcd;
            char a;
            char b;
            char c;
            char d;
            int sum;

            abcd = Console.Readline();
            a = abcd[0];
            b = abcd[1];
            c = abcd[2];
            d = abcd[3];

            sum = a - '0' + b - '0' + c - '0' + d - '0';
            Console.WriteLine(sum);
            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d + a + b + d);
            Console.WriteLine(a + c + b + d);

        }
    }
}
