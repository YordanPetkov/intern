using System;
using System.IO;

namespace _03.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tasksFileReader = new StreamReader("../../../Tasks.txt");
                var solvedTasksFileWriter = new StreamWriter("../../../SolvedTasks.txt");
                int numberOfLine = 0;
                string line = tasksFileReader.ReadLine();

                while(line != null)
                {
                    numberOfLine++;
                    solvedTasksFileWriter.WriteLine(numberOfLine + " " + line);
                    line = tasksFileReader.ReadLine();
                }

                tasksFileReader.Close();
                solvedTasksFileWriter.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
