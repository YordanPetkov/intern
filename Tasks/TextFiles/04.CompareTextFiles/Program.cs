using System;
using System.IO;

namespace _04.CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var firstFileReader = new StreamReader("../../../FirstFile.txt");
                var secondTasksFileReader = new StreamReader("../../../SecondFile.txt");
                int countSameLines = 0;
                int countDifferentLines = 0;
                string lineFromFirstFile = firstFileReader.ReadLine();
                string lineFromSecondFile = secondTasksFileReader.ReadLine();

                while (lineFromFirstFile != null && lineFromSecondFile != null)
                {
                    if (lineFromFirstFile == lineFromSecondFile)
                    {
                        countSameLines++;
                    }
                    else
                    {
                        countDifferentLines++;
                    }
                    lineFromFirstFile = firstFileReader.ReadLine();
                    lineFromSecondFile = secondTasksFileReader.ReadLine();
                }

                firstFileReader.Close();
                secondTasksFileReader.Close();
                Console.WriteLine("Same lines : {0}", countSameLines);
                Console.WriteLine("Different lines : {0}", countDifferentLines);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
