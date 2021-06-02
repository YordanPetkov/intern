using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    Console.WriteLine("Which table you want to update : (write the id of the table)");
                    int tableId = MenuLogic.SelectTable(tableNames);

                    int rowId = MenuLogic.SelectRow(tableNames, tableId);

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