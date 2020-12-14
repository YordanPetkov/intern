using System;

namespace _13.ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] marks = { ',', '.', '!', '?', ':', '-' };
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            char[] indexOfMarks = new char[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                foreach (char mark in marks)
                {
                    int wordLenght = words[i].Length;
                    if (words[i][wordLenght - 1] == mark)
                    {
                        indexOfMarks[i] = mark;
                        words[i] = words[i].Remove(wordLenght - 1, 1);
                        break;
                    }
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[words.Length - 1 - i]);
                Console.Write(indexOfMarks[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
