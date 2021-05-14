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

                    int k = -1;
                    foreach (var item in tableNames)
                    {
                        k++;
                        Console.WriteLine(k + " : " + item);
                    }

                    int tableId = int.Parse(Console.ReadLine());

                    if(tableId < 0 || tableId > k)
                    {
                        throw (new Exception("Invalid table id!"));
                    }

                    var countRows = dbContext.Database.ExecuteSqlCommand($"SELECT COUNT(Id) FROM {tableNames[tableId]}");
                    if(countRows < 1)
                    {
                        throw (new Exception($"Table {tableNames[tableId]} is empty."));
                    }

                    Console.WriteLine($"Which row you want to update ? 1 : {countRows}");

                    int rowId = int.Parse(Console.ReadLine());
                    if (tableId < 1 || tableId > countRows)
                    {
                        throw (new Exception("Invalid row id!"));
                    }

                    Console.WriteLine($"Which column from {tableNames[tableId]} you want to update : (write the id of the column)");
                    List<string> columnNames = dbContext.Database.SqlQuery<string>($"SELECT column_name FROM information_schema.columns WHERE table_name = N'{tableNames[tableId]}'").ToList();

                    k = 0;
                    foreach (var item in columnNames)
                    {
                        k++;
                        Console.WriteLine(k + " : " + item);
                    }

                    int columnId = int.Parse(Console.ReadLine());
                    if (columnId < 0 || columnId > k)
                    {
                        throw (new Exception("Invalid column id!"));
                    }

                    Console.WriteLine($"Write the new value of {columnNames[columnId]} : ");
                    string newValue = Console.ReadLine();
                    Console.WriteLine(newValue.Replace("\'", "\""));

                    dbContext.Database.ExecuteSqlCommand($"UPDATE {tableNames[tableId]} SET {columnNames[columnId]} = '{newValue}' WHERE Id = '{rowId}'");

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