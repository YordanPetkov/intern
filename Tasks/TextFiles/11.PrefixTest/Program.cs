using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.PrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tempFile = Path.GetTempFileName();

                using (var reader = new StreamReader("../../../file.txt"))
                using (var writer = new StreamWriter(tempFile))
                {
                    String word = "";
                    char letter = Convert.ToChar(reader.Read());

                    while(reader.Peek() >= 0)
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

                        if (!word.StartsWith("test"))
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

        static bool IsWordCharacter(char letter)
        {
            for (int i = 0; i <= 9; i++)
            {
                if(letter == '0' + i)
                {
                    return true;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if(letter == 'a' + i || letter == 'A' + i)
                {
                    return true;
                }
            }

            if(letter == '_')
            {
                return true;
            }

            return false;
        }
    }
}
