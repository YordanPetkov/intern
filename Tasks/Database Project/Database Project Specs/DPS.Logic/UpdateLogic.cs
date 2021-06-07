using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using System;
using System.Collections.Generic;

namespace DPS.Logic
{
    public class UpdateLogic : IUpdateLogic
    {
        public UpdateLogic()
        {

        }

        public void UpdateData()
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> tableNames = DatabaseLogic.GetTableNames();

                    Console.WriteLine("Which table you want to update : (write the id of the table)");
                    int tableId = MenuLogic.SelectTable(tableNames);

                    Console.WriteLine($"Which row you want to update ? {DatabaseLogic.GetMinId(tableNames[tableId])} : {DatabaseLogic.GetMaxId(tableNames[tableId])}");
                    int rowId = MenuLogic.SelectRow(tableNames, tableId);

                    List<string> columnNames = DatabaseLogic.GetColumnNames(tableNames[tableId]);
                    int columnId = MenuLogic.SelectColumn(tableNames, tableId);

                    string newValue = MenuLogic.GetNewValue(tableNames, tableId, columnId);

                    DatabaseLogic.UpdateById(tableNames[tableId], columnNames[columnId], rowId, newValue);

                    Console.WriteLine("The updation is done.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}