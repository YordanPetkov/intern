using DPS.Data;
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

                    i = -1;
                    Console.WriteLine(dbContext.Database);
                    var book = dbContext.Database.SqlQuery<Book>($"SELECT * FROM Books").ToList();
                    foreach (var item in book)
                    {
                        i++;
                        Console.WriteLine(i + " " + item.Title);
                    }

                    Console.WriteLine($"Which column from {tableNames[tableId]} you want to update : (write the id of the column)");
                    List<string> columnNames = dbContext.Database.SqlQuery<string>($"SELECT column_name FROM information_schema.columns WHERE table_name = N'{tableNames[tableId]}'").ToList();

                    i = -1;
                    foreach (var item in columnNames)
                    {
                        i++;
                        Console.WriteLine(i + " : " + item);
                    }

                    int columnId = int.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}