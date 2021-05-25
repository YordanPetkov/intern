using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using DPS.Models;
using System;
using System.Collections.Generic;
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

            foreach (var item in list)
            {
                Console.WriteLine(item);
                var json = serializer.Serialize(item);
                Console.WriteLine(json);
            }
        }
    }
}