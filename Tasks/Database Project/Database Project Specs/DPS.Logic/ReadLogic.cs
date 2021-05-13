using DPS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic
{
    public class ReadLogic : IReadLogic
    {
        public ReadLogic()
        {

        }

        public void ReadData()
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    Console.WriteLine("From which table you want to read : (write the id of the table)");

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

                    var result = dbContext.Database.ExecuteSqlCommand($"SELECT * FROM {tableNames[tableId]}");
                    if(result == -1)
                    {
                        Console.WriteLine("Table is empty!");
                    }

                    else
                    {
                        Console.WriteLine(result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}