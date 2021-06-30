using DPS.Data;
using DPS.Logic;
using DPS.Logic.DatabaseUtilities;
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
            Console.WriteLine("If you want to check some of our records in our library - 'read'");
            Console.WriteLine("If you want to update the information about any book in our library - 'update'");
            Console.WriteLine("If you want to delete any information in our library - 'delete'");
            Console.WriteLine("If you want see all commands - 'help'");
            Console.WriteLine("If you want to quit the application - 'exit'");
            Console.WriteLine("----------------------------------------------------------------------------");
        }

        public void Run()
        {
            PrintCommands();

            while(true)
            {
                Console.Write("-");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "create":
                        Create();
                        break;

                    case "read":
                        Read();
                        break;

                    case "update":
                        Update();
                        break;

                    case "delete":
                        Delete();
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

        private void Create()
        {
            Console.WriteLine("Input the path of the JSON file :");
            Console.Write("-");

            string path = Console.ReadLine();
            createLogic.CreateData(path);

            Console.WriteLine("Creation is finished.");
        }

        private void Update()
        {
            List<string> tableNames = DatabaseLogic.GetTableNames();

            Console.WriteLine("Which table you want to update : (write the id of the table)");
            int tableId = MenuLogic.SelectTable(tableNames);

            Console.WriteLine($"Which row you want to update ? {DatabaseLogic.GetMinId(tableNames[tableId])} : {DatabaseLogic.GetMaxId(tableNames[tableId])}");
            int rowId = MenuLogic.SelectRow(tableNames, tableId);

            updateLogic.UpdateData(tableNames, tableId, rowId);

            Console.WriteLine("The updation is done.");
        }

        private void Read()
        {
            Console.WriteLine("From which table you want to read : (write the id of the table)");

            readLogic.ReadData();

            Console.WriteLine("Reading is done.");
        }

        private void Delete()
        {
            List<string> tableNames = DatabaseLogic.GetTableNames();

            int tableId = MenuLogic.SelectTable(tableNames);

            Console.WriteLine($"Which row you want to delete ? {DatabaseLogic.GetMinId(tableNames[tableId])} : {DatabaseLogic.GetMaxId(tableNames[tableId])}");

            deleteLogic.DeleteData();

            Console.WriteLine("Deletion is done.");
        }
    }

}