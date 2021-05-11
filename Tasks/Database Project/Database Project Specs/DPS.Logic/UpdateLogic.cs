using DPS.Data;
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
                    List<string> tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    Console.WriteLine("Which table you want to update : (write the id of the table)");

                    int i = -1;
                    foreach (var item in tableNames)
                    {
                        i++;
                        Console.WriteLine(i + " : " + item);
                    }

                    int tableId = int.Parse(Console.ReadLine());

                    if(tableId < 0 || tableId > i)
                    {
                        throw (new Exception("Invalid table id!"));
                    }

                    var columnNames = dbContext.Database.SqlQuery<string>($"SELECT name FROM sys.columns WHERE object_name = OBJECT_NAME({tableNames[tableId]});").ToList();
                    
                    i = -1;
                    foreach (var item in columnNames)
                    {
                        i++;
                        Console.WriteLine(i + " : " + item);
                    }

                    Console.WriteLine(tableNames[tableId]);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
