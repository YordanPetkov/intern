using DPS.Data;
using DPS.Logic.DatabaseUtilities;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                            var bookList = dbContext.Books.ToList<Book>();
                            AddToJsonFile(bookList);
                            break;

                        case "AuthorNicknames":
                            var nicknameList = dbContext.Nicknames.ToList<AuthorNickname>();
                            AddToJsonFile(nicknameList);
                            break;

                        case "AuthorRealNames":
                            var authorList = dbContext.Authors.ToList<AuthorRealName>();
                            AddToJsonFile(authorList);
                            break;

                        case "Genres":
                            var genreList = dbContext.Genres.ToList<Genre>();
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

        private void AddToJsonFile<T>(List<T> modelList) where T : class
        {
            var serializer = new JavaScriptSerializer();
            Console.WriteLine("Write a name for the file :");
            var path = Console.ReadLine();
            path = path.Replace('/', '_');
            path = path.Replace('\\', '_');
            path = path.Replace('.', '_');

            using (StreamWriter writer = new StreamWriter("../../../" + path + ".json"))
            {
                writer.WriteLine("[");

                for (int i = 0; i < modelList.Count; i++)
                {
                    var json = serializer.Serialize(modelList[i]);
                    writer.WriteLine(json);
                    if (i < modelList.Count - 1)
                    {
                        writer.WriteLine(",");
                    }
                }

                writer.WriteLine("]");
            }
        }
    }
}