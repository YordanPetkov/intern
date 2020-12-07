using System;
using System.Text;

namespace _07.EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string cipher = Console.ReadLine();
            int j = 0;
            int size = text.ToString().Length;

            for (int i = 0; i < size; i++)
            {
                text[i] = (char)(text[i] ^ cipher[j]);
                j++;
                if(j >= cipher.Length)
                {
                    j = 0;
                }
            }

            Console.WriteLine(text.ToString());
        }
    }
}
