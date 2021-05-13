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

        private void PrintCommands()
        {
            Console.WriteLine("If you want to create a new record to our library - 'create'");
            Console.WriteLine("If you want to check some of our records in library - 'read'");
            Console.WriteLine("If you want to update the information about any book in our library - 'update'");
            Console.WriteLine("If you want to delete any information in our library - 'delete'");
            Console.WriteLine("If you want see all commands - 'help'");
            Console.WriteLine("If you want to exit from application - 'exit'");
            Console.WriteLine("----------------------------------------------------------------------------");
        }

        public void Run()
        {
            PrintCommands();

            while(true)
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "create":
                        Console.WriteLine("Create");
                        break;

                    case "read":
                        readLogic.ReadData();
                        break;

                    case "update":
                        updateLogic.UpdateData();
                        break;

                    case "delete":
                        deleteLogic.DeleteData();
                        break;

                    case "help":
                        PrintCommands();
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
    }
}