using System;
using System.Collections.Generic;

namespace _22.WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var countWords = new Dictionary<string, int>();
            string[] words = text.Split('.', ' ', '!', '?', ',');

            foreach (string word in words)
            {
                if(word == "")
                {
                    continue;
                }
                try
                {
                    countWords[word]++;
                }
                catch(KeyNotFoundException e)
                {
                    countWords[word] = 1;
                }
                
            }

            foreach (var item in countWords)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}
