using DPS.Data;
using DPS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using DPS.Logic.DatabaseUtilities;

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

                    using (StreamReader reader = new StreamReader(path))
                    {
                        string json = reader.ReadToEnd();

                        CreationModel creationModel = JsonConvert.DeserializeObject<CreationModel>(json);

                        if(!(creationModel.genres is null))
                        {
                            foreach (var genre in creationModel.genres)
                            {
                                dbContext.Genres.Add(new Genre 
                                {
                                    Name = genre.Name 
                                });
                            }
                        }
                        
                        if(!(creationModel.nicknames is null))
                        {
                            foreach (var nickname in creationModel.nicknames)
                            {
                                dbContext.Nicknames.Add(new AuthorNickname 
                                {
                                    Name = nickname.Name 
                                });
                            }
                        }
                        
                        if(!(creationModel.authors is null))
                        {
                            foreach (var author in creationModel.authors)
                            {
                                dbContext.Authors.Add(new AuthorRealName
                                {
                                    FirstName = author.FirstName,
                                    LastName = author.LastName,
                                    Country = author.Country,
                                    NicknameId = author.NicknameId,
                                    Nickname = dbContext.Nicknames.Find(author.NicknameId)
                                });
                            }
                        }
                        
                        if(!(creationModel.books is null))
                        {
                            foreach (var book in creationModel.books)
                            {
                                var genres = new List<Genre>();
                                foreach (var genre in book.Genres)
                                {
                                    genres.Add(dbContext.Genres.Find((int)genre.Id));
                                }

                                Book newBook = new Book
                                {
                                    Title = book.Title,
                                    Year = book.Year,
                                    AuthorNicknameId = book.AuthorNicknameId,
                                    Author = dbContext.Nicknames.Find(book.AuthorNicknameId),
                                    Genres = genres
                                };

                                dbContext.Books.Add(newBook);
                            }
                        }

                        dbContext.SaveChanges();
                    }

                    Console.WriteLine("Creation is finished.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}