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
                List<string> tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();
                tableNames.RemoveAll(p => p == "__MigrationHistory");

                Console.WriteLine("Which table you want to update : (write the id of the table)");
                int i = 0;
                foreach (var item in tableNames)
                {
                    i++;
                    Console.WriteLine(i + " : " + item);
                }

                try
                {
                    int tableId = int.Parse(Console.ReadLine());
                    if(tableId < 1 || tableId > i)
                    {
                        throw (new Exception("Invalid id!"));
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
