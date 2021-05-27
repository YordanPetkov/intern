using DPS.Data;
using DPS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        var obj = JsonConvert.DeserializeObject<dynamic>(json);

                        if(!(obj.Genres is null))
                        {
                            foreach (var item in obj.Genres)
                            {
                                dbContext.Genres.Add(new Genre { Name = item.Name });
                            }
                        }
                        
                        if(!(obj.Nicknames is null))
                        {
                            foreach (var item in obj.Nicknames)
                            {
                                dbContext.Nicknames.Add(new AuthorNickname { Name = item.Name });
                            }
                        }
                        
                        if(!(obj.Authors is null))
                        {
                            foreach (var item in obj.Authors)
                            {
                                int nicknameId = (int)item.NicknameId;
                                dbContext.Authors.Add(new AuthorRealName
                                {
                                    FirstName = item.Firstname,
                                    LastName = item.Lastname,
                                    Country = item.Country,
                                    Nickname = dbContext.Nicknames.Find(nicknameId)
                                });
                            }
                        }
                        
                        if(!(obj.Books is null))
                        {
                            foreach (var item in obj.Books)
                            {
                                /*r genres = new List<Genre>();

                                foreach (var genre in item.Genres)
                                {
                                    Console.WriteLine(item.Genres);
                                    genres.Add(dbContext.Genres.Find((int)genre.GenreId));
                                }*/

                                Book newBook = new Book
                                {
                                    Title = item.Title,
                                    Year = item.Year,
                                    AuthorNicknameId = item.AuthorNicknameId,
                                    Author = dbContext.Nicknames.Find((int)item.AuthorNicknameId)
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