using System;
using System.Text;

namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sequenceUnicode = new StringBuilder();

            foreach (char c in input)
            {
                sequenceUnicode.AppendFormat("\\u{0:X4}", (int)c);
            }

            Console.WriteLine(sequenceUnicode.ToString());
        }
    }
}
