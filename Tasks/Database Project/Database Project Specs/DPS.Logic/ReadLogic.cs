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
                Console.WriteLine("Choose a table from where you want to read.");
                Console.WriteLine("Books/Authors/Genres");
                string table = Console.ReadLine();

                switch(table.ToLower())
                {
                    case "books":
                        break;
                    case "authors":
                        break;
                    case "genres":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}