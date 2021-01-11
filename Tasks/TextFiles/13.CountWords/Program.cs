using System;
using System.Collections.Generic;
using System.IO;

namespace _13.CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Pair> givenWords = GetWords("../../../words.txt");
                using (var reader = new StreamReader("../../../test.txt"))
                {
                    String word = "";
                    char letter = Convert.ToChar(reader.Read());

                    while (reader.Peek() >= 0)
                    {
                        word = "";
                        do
                        {
                            if (IsWordCharacter(letter))
                            {
                                word += letter;
                            }
                            letter = Convert.ToChar(reader.Read());
                        } while (IsWordCharacter(letter));

                        foreach (var givenWord in givenWords)
                        {
                            if (word == givenWord.Item1)
                            {
                                givenWord.Item2++;
                                break;
                            }
                        }
                    }
                }
                givenWords.Sort((x,y)=> x.Item2.CompareTo(y.Item2));
                using (var writer = new StreamWriter("../../../result.txt"))
                {
                    foreach(var givenWord in givenWords)
                    {
                        writer.WriteLine(givenWord.Item1 + ":" + givenWord.Item2);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }

        static List<Pair> GetWords(string path)
        {
            List<Pair> wordsList = new List<Pair>();
            using (var readerWords = new StreamReader(path))
            {
                string line = readerWords.ReadLine();

                while (line != null)
                {
                    string[] words = line.Split(' ', ',', '.', '!', '?');

                    foreach (var word in words)
                    {
                        wordsList.Add(new Pair(word, 0));
                    }

                    line = readerWords.ReadLine();
                }
            }
            return wordsList;
        }
        static bool IsWordCharacter(char letter)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (letter == '0' + i)
                {
                    return true;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (letter == 'a' + i || letter == 'A' + i)
                {
                    return true;
                }
            }

            if (letter == '_')
            {
                return true;
            }

            return false;
        }
    }
}
