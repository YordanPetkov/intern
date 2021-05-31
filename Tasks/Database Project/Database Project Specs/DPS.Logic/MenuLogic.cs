using DPS.Logic.DatabaseUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic
{
    public static class MenuLogic
    {
        public static int SelectTable(List<string> tableNames)
        {

            for (int i = 0; i < tableNames.Count; i++)
            {
                Console.WriteLine(i + " : " + tableNames[i]);
            }

            int tableId = int.Parse(Console.ReadLine());

            if (tableId < 0 || tableId > tableNames.Count)
            {
                throw (new Exception("Invalid table id!"));
            }

            return tableId;
        }

        public static int SelectRow(List<string> tableNames, int tableId)
        {

            if (1 > DatabaseLogic.GetMaxId(tableNames[tableId]))
            {
                throw (new Exception($"Table {tableNames[tableId]} is empty."));
            }

            Console.WriteLine($"Which row you want to update ? {DatabaseLogic.GetMinId(tableNames[tableId])} : {DatabaseLogic.GetMaxId(tableNames[tableId])}");

            int rowId = int.Parse(Console.ReadLine());
            if (tableId < DatabaseLogic.GetMinId(tableNames[tableId]) || tableId > DatabaseLogic.GetMaxId(tableNames[tableId]))
            {
                throw (new Exception("Invalid row id!"));
            }

            return rowId;
        }

        public static int SelectColumn(List<string> tableNames, int tableId)
        {
            Console.WriteLine($"Which column from {tableNames[tableId]} you want to update : (write the id of the column)");
            List<string> columnNames = DatabaseLogic.GetColumnNames(tableNames[tableId]);

            for (int i = 0; i < columnNames.Count; i++)
            {
                Console.WriteLine(i + " : " + columnNames[i]);
            }

            int columnId = int.Parse(Console.ReadLine());
            if (columnId < 0 || columnId > columnNames.Count)
            {
                throw (new Exception("Invalid column id!"));
            }

            return columnId;
        }

        public static string GetNewValue(List<string> tableNames, int tableId, int columnId)
        {
            List<string> columnNames = DatabaseLogic.GetColumnNames(tableNames[tableId]);
            Console.WriteLine($"Write the new value of {columnNames[columnId]} : ");
            string newValue = Console.ReadLine();


            return newValue.Replace("\'", "\"");
        }
    }
}