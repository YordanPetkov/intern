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
                var title = dbContext.Database.SqlQuery<string> ("Select Title from Books where Id=1").FirstOrDefault();
                //Console.WriteLine(Json(title, JsonRequestBehavior.AllowGet));
                Console.WriteLine(title);

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