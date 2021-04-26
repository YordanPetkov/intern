using DPS.Data;
using DPS.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Client
{
    public class Application : IApplication
    {
        ICreateLogic createLogic;
        IReadLogic readLogic;
        IDeleteLogic deleteLogic;
        IUpdateLogic updateLogic;

        public Application(ICreateLogic createLogic, IReadLogic readLogic, IUpdateLogic updateLogic, IDeleteLogic deleteLogic)
        {
            this.createLogic = createLogic;
            this.readLogic = readLogic;
            this.updateLogic = updateLogic;
            this.deleteLogic = deleteLogic;
        }
        public void Run()
        {
            Console.WriteLine("             Choose an option.");
            Console.WriteLine("If you want to create a new book to our library - 'c'");
            Console.WriteLine("If you want to check some of our books in library - 'r'");
            Console.WriteLine("If you want to update the information about any book in our library - 'u'");
            Console.WriteLine("If you want to delete any book in our library - 'd'");

            char option = Char.Parse(Console.ReadLine());
            switch (option)
            {
                case 'c':
                    Console.WriteLine("Create");
                    break;

                case 'r':
                    Console.WriteLine("Read");
                    break;

                case 'u':
                    Console.WriteLine("Update");
                    break;

                case 'd':
                    Console.WriteLine("Delete");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}