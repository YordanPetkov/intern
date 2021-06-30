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

        public void UpdateData(List<string> tableNames, int tableId, int rowId)
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> columnNames = DatabaseLogic.GetColumnNames(tableNames[tableId]);
                    int columnId = MenuLogic.SelectColumn(tableNames, tableId);

                    string newValue = MenuLogic.GetNewValue(tableNames, tableId, columnId);
                        
                    DatabaseLogic.UpdateById(tableNames[tableId], columnNames[columnId], rowId, newValue);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}