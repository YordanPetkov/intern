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
            Console.WriteLine("If you want to create a new book to our library - 'create'");
            Console.WriteLine("If you want to check some of our books in library - 'read'");
            Console.WriteLine("If you want to update the information about any book in our library - 'update'");
            Console.WriteLine("If you want to delete any book in our library - 'delete'");
            Console.WriteLine("----------------------------------------------------------------------------");

            string option = Console.ReadLine();
            switch (option)
            {
                case "create":
                    Console.WriteLine("Create");
                    break;

                case "read":
                    Console.WriteLine("Read");
                    readLogic.ReadData();
                    break;

                case "update":
                    Console.WriteLine("Update");
                    updateLogic.UpdateData();
                    break;

                case "delete":
                    Console.WriteLine("Delete");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}