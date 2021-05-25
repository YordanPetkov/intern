using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic
{
    public class DeleteLogic : IDeleteLogic
    {
        public DeleteLogic()
        {

        }

        public void DeleteData()
        {
            using(var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> tableNames = DatabaseLogic.GetTableNames();
                    
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    int tableId = MenuLogic.SelectTable(tableNames);

                    int rowId = MenuLogic.SelectRow(tableNames, tableId);

                    DatabaseLogic.Delete(tableNames[tableId], rowId);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private int SelectTable(List<string> tableNames)
        {
            Console.WriteLine("From which table you want to delete : (write the id of the table)");

            for (int i = 0; i < tableNames.Count; i++)
            {
                Console.WriteLine(i + " : " + tableNames[i]);
            }

            int tableId = int.Parse(Console.ReadLine());

            if (tableId < 0 || tableId > tableNames.Count)
            {
                throw (new Exception("Invalid table id!"));
            }

            return tableId;
        }

        private int SelectRow(List<string> tableNames, int tableId)
        {
            var countRows = DatabaseLogic.GetNumberOfRows(tableNames[tableId]);
            if (countRows < 1)
            {
                throw (new Exception($"Table {tableNames[tableId]} is empty."));
            }

            Console.WriteLine($"Which row you want to delete ? 1 : {countRows}");

            int rowId = int.Parse(Console.ReadLine());
            if (tableId < 1 || tableId > countRows)
            {
                throw (new Exception("Invalid row id!"));
            }

            return rowId;
        }
    }
}
