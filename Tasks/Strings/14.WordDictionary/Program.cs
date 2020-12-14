using System;
using System.Collections.Generic;

namespace _14.WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = @"If you want to add new word, type : @add_<word>_<explanation>
If you want to check any word, type : @check_<word>
If you want to check all available words, type @all
If you want to see the instructions, type @help
If you want to close the application, type @close";
            Console.WriteLine(instructions);
            var dictionary = new Dictionary<string, string>();
            dictionary[".NET"] = "platform for applications from Microsoft";
            dictionary["CLR"] = " managed execution environment for .NET";
            dictionary["namespace"] = " hierarchical organization of classes";
            string command = "";

            do
            {
                command = Console.ReadLine();
                string[] parts = command.Split('_');
                switch (parts[0])
                {
                    case "@add":
                        if (parts.Length != 3)
                        {
                            Console.WriteLine("Undefined command.");
                        }
                        else
                        {
                            dictionary[parts[1]] = parts[2];
                        }
                        break;
                    case "@check":
                        if (parts.Length != 2)
                        {
                            Console.WriteLine("Undefined command.");
                        }
                        else if (!dictionary.ContainsKey(parts[1]))
                        {
                            Console.WriteLine("Undefined word.");
                        }
                        else
                        {
                            Console.WriteLine(dictionary[parts[1]]);
                        }
                        break;
                    case "@all":

                        foreach (var word in dictionary)
                        {
                            Console.WriteLine("{0} : {1}", word.Key, word.Value);
                        }
                        break;

                    case "@help":
                        Console.WriteLine(instructions);
                        break;
                    case "@close":
                        break;
                    default:
                        Console.WriteLine("Undefined command.");
                        break;
                }
            } while (command != "@close");

        }
    }
}
