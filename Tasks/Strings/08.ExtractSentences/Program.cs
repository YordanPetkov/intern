using System;
using System.Text;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string[] sentences = text.ToString().Split('.');
            string keyWord = Console.ReadLine();

            foreach (string sentence in sentences)
            {
                char[] symbols = { ',', '.', '!', '?', ' ', ';', '\"', '\''};
                string [] words = sentence.Split(symbols);
                foreach (string word in words)
                {
                    if(keyWord == word)
                    {
                        Console.Write(sentence + '.');
                        break;
                    }
                }
            }

        }
    }
}
