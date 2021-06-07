using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using System;
using System.Collections.Generic;

namespace DPS.Logic
{
    public class DeleteLogic : IDeleteLogic
    {
        public DeleteLogic()
        {

        }

        public void DeleteData()
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> tableNames = DatabaseLogic.GetTableNames();

                    int tableId = MenuLogic.SelectTable(tableNames);

                    Console.WriteLine($"Which row you want to delete ? {DatabaseLogic.GetMinId(tableNames[tableId])} : {DatabaseLogic.GetMaxId(tableNames[tableId])}");
                    int rowId = MenuLogic.SelectRow(tableNames, tableId);

                    DatabaseLogic.Delete(tableNames[tableId], rowId);

                    Console.WriteLine("Deletion is done.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}