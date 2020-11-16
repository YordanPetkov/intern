using System;

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] - 'a');
            }
        }
    }
}
