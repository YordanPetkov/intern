using System;

namespace _20.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                bool isPalindrome = true;
                
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if(word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if(isPalindrome)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
