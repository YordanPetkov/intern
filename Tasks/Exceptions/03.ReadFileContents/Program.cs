using System;
using System.IO;
using System.Text;

namespace _03.ReadFileContents
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Attempted to access a path that is not on the disk.");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("Could not find the drive. The drive might not be ready or might not be mapped.");
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("Attempted to read past the end of the stream.");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Could not load the specified file.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to find the specified file.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified file name or path is too long, or a component of the specified path is too long.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access to the path {0} is denied.", path);
            }
            catch (IOException)
            {
                Console.WriteLine("The filename, directory name, or volume label syntax is incorrect.");
            }
        }
    }
}
