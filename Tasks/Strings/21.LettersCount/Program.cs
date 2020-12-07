using System;

namespace _21.LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] counters = new int[26];
            foreach (char c in text)
            {
                if(('a' <= c && c >= 'z') || ('A' <= c && c >= 'Z'))
                {
                    counters[Char.ToLower(c) - 'a']++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if(counters[i] != 0)
                {
                    Console.WriteLine("{0} : {1}", (char)('a' + i), counters[i]);
                }
            }
        }
    }
}
