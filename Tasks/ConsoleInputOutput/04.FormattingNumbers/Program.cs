using System;

namespace _04.FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            double c;
            string hexA;
            string binaryA;
            string formatedB;
            string formatedC;

            a = int.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            hexA = string.Format("{0,-10:X}", a);
            binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
            formatedB = string.Format("{0,10:0.00}", b);
            formatedC = string.Format("{0,-10:0.000}", c);

            Console.WriteLine("|{0}|{1}|{2}|{3}|", hexA, binaryA, formatedB, formatedC);
        }
    }
}
