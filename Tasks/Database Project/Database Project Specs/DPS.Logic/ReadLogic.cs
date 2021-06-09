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

                    Console.WriteLine("From which table you want to read : (write the id of the table)");
                    int tableId = MenuLogic.SelectTable(tableNames);

                    Console.WriteLine(tableNames[tableId]);
                    switch (tableNames[tableId])
                    {
                        case "Books":
                            var bookList = dbContext.Books.ToList<Book>();
                            //List<Genre>[] genres = new List<Genre>[bookList.Count];
                            //int index = 0;

                            foreach (var book in bookList)
                            {
                                book.Author = new AuthorNickname
                                {
                                    Id = dbContext.Nicknames.Where(x => x.Id == book.AuthorNicknameId).Select(o => o.Id).FirstOrDefault(),
                                    Name = dbContext.Nicknames.Where(x => x.Id == book.AuthorNicknameId).Select(o => o.Name).FirstOrDefault()
                                };

                                /*List<int> genreIds = dbContext.Database.SqlQuery<int>($"SELECT Genre_Id FROM GenreBooks WHERE Book_Id = {book.Id}").ToList();
                                //var genreIds = dbContext.Books.Select(x => new { x.Id }).ToArray();

                                foreach (var id in genreIds)
                                {
                                    genres[index].Add(new Genre
                                    {
                                        Id = id,
                                        Name = dbContext.Genres.Find(id).Name
                                    });
                                }

                                index++;*/
                            }

                            //AddToJsonFile(bookList, true, genres);
                            AddToJsonFile(bookList);
                            break;

                        case "AuthorNicknames":
                            var nicknameList = dbContext.Nicknames.ToList<AuthorNickname>();

                            AddToJsonFile(nicknameList);
                            break;

                        case "AuthorRealNames":
                            var authorList = dbContext.Authors.ToList<AuthorRealName>();
                            foreach (var author in authorList)
                            {
                                author.Nickname = new AuthorNickname
                                {
                                    Id = dbContext.Nicknames.Where(x => x.Id == author.NicknameId).Select(o => o.Id).FirstOrDefault(),
                                    Name = dbContext.Nicknames.Where(x => x.Id == author.NicknameId).Select(o => o.Name).FirstOrDefault()
                                };
                            }

                            AddToJsonFile(authorList);
                            break;

                        case "Genres":
                            var genreList = dbContext.Genres.ToList<Genre>();
                            AddToJsonFile(genreList);
                            break;

                        default:
                            throw new Exception("Undefined table!");
                    }

                    Console.WriteLine("Reading is done.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void AddToJsonFile<T>(List<T> modelList, bool isBook = false, List<Genre>[] genres = null) where T : class
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

                    if (isBook)
                    {
                        var jsonGenres = serializer.Serialize(genres[i]);
                        json.Insert(json.Length - 2, jsonGenres);
                    }

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