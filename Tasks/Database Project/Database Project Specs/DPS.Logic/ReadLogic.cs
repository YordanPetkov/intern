using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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
                    List<string> tableNames = DatabaseLogic.GetTableNames();
                    tableNames.RemoveAll(p => p == "__MigrationHistory");

                    Console.WriteLine("From which table you want to read : (write the id of the table)");
                    int tableId = MenuLogic.SelectTable(tableNames);

                    Console.WriteLine(tableNames[tableId]);
                    switch (tableNames[tableId])
                    {
                        case "Books":
                            var bookList = dbContext.Books.SqlQuery("Select * from Books").ToList<Book>();
                            AddToJsonFile(bookList);
                            break;

                        case "AuthorNicknames":
                            var nicknameList = dbContext.Nicknames.SqlQuery("Select * from AuthorNicknames").ToList<AuthorNickname>();
                            AddToJsonFile(nicknameList);
                            break;

                        case "AuthorRealNames":
                            var authorList = dbContext.Authors.SqlQuery("Select * from AuthorRealNames").ToList<AuthorRealName>();
                            AddToJsonFile(authorList);
                            break;

                        case "Genres":
                            var genreList = dbContext.Genres.SqlQuery("Select * from Genres").ToList<Genre>();
                            AddToJsonFile(genreList);
                            break;

                        default:
                            throw new Exception("Undefined table.");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void AddToJsonFile<T>(List<T> list) where T : class
        {
            var serializer = new JavaScriptSerializer();
            Console.WriteLine("Write a name for the file :");
            var path = Console.ReadLine();
            path = path.Replace('/', '_');
            path = path.Replace('\\', '_');
            path = path.Replace('.', '_');

            using (StreamWriter w = new StreamWriter("../../../" + path + ".json"))
            {
                w.WriteLine("[");
            }

            using (StreamWriter w = new StreamWriter("../../../" + path + ".json", true))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var json = serializer.Serialize(list[i]);
                    w.WriteLine(json);
                    if (i < list.Count - 1)
                    {
                        w.WriteLine(",");
                    }
                }

                w.WriteLine("]");
            }
        }
    }
}