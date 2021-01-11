using System;
using System.Collections.Generic;
using System.IO;

namespace _12.RemoveWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tempFile = Path.GetTempFileName();
                List<string> givenWords = GetWords("../../../words.txt");
                using (var reader = new StreamReader("../../../file.txt"))
                using (var writer = new StreamWriter(tempFile))
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

                        bool isWordFromList = false;

                        foreach (var givenWord in givenWords)
                        {
                            if(word == givenWord)
                            {
                                isWordFromList = true;
                                break;
                            }
                        }

                        if(!isWordFromList)
                        {
                            writer.Write(word);
                        }
                        writer.Write(letter);
                    }

                }
                File.Delete("../../../file.txt");
                File.Move(tempFile, "../../../file.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }

        static List<string> GetWords(string path)
        {
            List<string> wordsList = new List<string>();
            using (var readerWords = new StreamReader(path))
            {
                string line = readerWords.ReadLine();

                while (line != null)
                {
                    string[] words = line.Split(' ', ',', '.', '!', '?');

                    foreach (var word in words)
                    {
                        wordsList.Add(word);
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
