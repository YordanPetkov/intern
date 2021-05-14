using DPS.Data;
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
                    List<string> tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    Console.WriteLine("From which table you want to delete : (write the id of the table)");

                    int k = -1;
                    foreach (var item in tableNames)
                    {
                        k++;
                        Console.WriteLine(k + " : " + item);
                    }

                    int tableId = int.Parse(Console.ReadLine());

                    if (tableId < 0 || tableId > k)
                    {
                        throw (new Exception("Invalid table id!"));
                    }

                    var countRows = dbContext.Database.ExecuteSqlCommand($"SELECT COUNT(Id) FROM {tableNames[tableId]}");
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

                    dbContext.Database.ExecuteSqlCommand($"DELETE FROM {tableNames[tableId]} WHERE Id = '{rowId}'");

                    dbContext.SaveChanges();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
