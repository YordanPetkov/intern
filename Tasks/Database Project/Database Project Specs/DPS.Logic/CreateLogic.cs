using DPS.Data;
using DPS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using DPS.Logic.DatabaseUtilities;
using System.Web.Script.Serialization;

namespace DPS.Logic
{
    public class CreateLogic : ICreateLogic
    {
        public CreateLogic()
        {

        }

        public void CreateData()
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    Console.WriteLine("Input the path of the JSON file :");
                    Console.Write("-");

                    string path = Console.ReadLine();
                    List<string> tableNames = DatabaseLogic.GetTableNames();

                    using (StreamReader r = new StreamReader(path))
                    {
                        string json = r.ReadToEnd();

                        var jsonObject = JToken.Parse(json);
                        var JSONObj = new JavaScriptSerializer().Deserialize<Genre>(json);
                        CreationModel obj = JsonConvert.DeserializeObject<CreationModel>(json);

                        if(!(obj.genres is null))
                        {
                            foreach (var item in obj.genres)
                            {
                                dbContext.Genres.Add(new Genre { Name = item.Name });
                            }
                        }
                        
                        if(!(obj.nicknames is null))
                        {
                            foreach (var item in obj.nicknames)
                            {
                                dbContext.Nicknames.Add(new AuthorNickname { Name = item.Name });
                            }
                        }
                        
                        if(!(obj.authors is null))
                        {
                            foreach (var item in obj.authors)
                            {
                                //int nicknameId = (int)item.AuthorNicknameId;
                                dbContext.Authors.Add(new AuthorRealName
                                {
                                    FirstName = item.FirstName,
                                    LastName = item.LastName,
                                    Country = item.Country,
                                    NicknameId = item.NicknameId,
                                    //Nickname = item.Nickname
                                    Nickname = dbContext.Nicknames.Find(item.NicknameId)
                                });
                            }
                        }
                        
                        if(!(obj.books is null))
                        {
                            foreach (var item in obj.books)
                            {
                                var genres = new List<Genre>();
                                /* foreach (var genre in item.Genres)
                                 {
                                     genres.Add(dbContext.Genres.Find((int)genre.GenreId));
                                 }*/

                                Book newBook = new Book
                                {
                                    Title = item.Title,
                                    Year = item.Year,
                                    AuthorNicknameId = item.AuthorNicknameId,
                                    Author = item.Author,
                                    //Author = dbContext.Nicknames.Find((int)item.AuthorNicknameId),
                                    Genres = item.Genres
                                };

                                dbContext.Books.Add(newBook);
                            }
                        }

                        dbContext.SaveChanges();
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