using System;
using System.IO;

namespace _09.DeleteOddLines
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
                    string line = reader.ReadLine();
                    int countLines = 0;

                    while (line != null)
                    {
                        countLines++;
                        if(countLines % 2 != 1)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
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
    }
}
