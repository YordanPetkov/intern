using DPS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic.DatabaseUtilities
{
    public static class DatabaseLogic
    {
        public static List<string> GetTableNames()
        {
            List<string> tableNames;
            using (var dbContext = new LibraryDbContext())
            {
                tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();

            }

            return tableNames;
        }

        public static List<string> GetColumnNames(string table)
        {
            List<string> columnNames;
            using (var dbContext = new LibraryDbContext())
            {
                columnNames = dbContext.Database.SqlQuery<string>($"SELECT column_name FROM information_schema.columns WHERE table_name = N'{table}'").ToList();
            }

            return columnNames;
        }

        public static void Delete(string table, int id)
        {
            using (var dbContext = new LibraryDbContext())
            {
                dbContext.Database.ExecuteSqlCommand($"DELETE FROM {table} WHERE Id = '{id}'");
                dbContext.SaveChanges();
            }
        }

        public static void UpdateById(string table, string column, int id, string newValue)
        {
            using (var dbContext = new LibraryDbContext())
            {
                dbContext.Database.ExecuteSqlCommand($"UPDATE {table} SET {column} = '{newValue}' WHERE Id = '{id}'");
                dbContext.SaveChanges();
            }
        }

        public static int GetNumberOfRows(string table)
        {
            int countRows;
            using (var dbContext = new LibraryDbContext())
            {
                countRows = dbContext.Database.ExecuteSqlCommand($"SELECT COUNT(Id) FROM {table}");
            }

            return countRows;
        }
    }
}
