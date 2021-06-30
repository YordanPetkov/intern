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

                    int rowId = MenuLogic.SelectRow(tableNames, tableId);

                    DatabaseLogic.Delete(tableNames[tableId], rowId);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}