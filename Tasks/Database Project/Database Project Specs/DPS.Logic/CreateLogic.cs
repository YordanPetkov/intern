﻿using DPS.Data;
using DPS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string path = Console.ReadLine();
                    List<string> tableNames = dbContext.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList();

                    using (StreamReader r = new StreamReader(path))
                    {
                        string json = r.ReadToEnd();
                        dynamic array = JsonConvert.DeserializeObject(json);

                        foreach (var item in array)
                        {
                            Console.WriteLine(item.ToString());
                            if (item.Book != null)
                            {
                                Book newBook = JsonConvert.DeserializeObject<Book>(item);
                                Console.WriteLine(newBook.ToString());
                                dbContext.Books.Add(newBook);
                            }

                            if (item.Nickname != null)
                            {
                                AuthorNickname newNickname = JsonConvert.DeserializeObject<AuthorNickname>(item);
                                Console.WriteLine(newNickname.Name);
                                dbContext.Nicknames.Add(newNickname);
                            }

                            if (item.Author != null)
                            {
                                AuthorRealName newRealname = JsonConvert.DeserializeObject<AuthorRealName>(item);
                                Console.WriteLine(newRealname.ToString());
                                dbContext.Authors.Add(newRealname);
                            }

                            if (item.Genre != null)
                            {
                                Genre newGenre = JsonConvert.DeserializeObject<Genre>(item);
                                Console.WriteLine(newGenre.ToString());
                                dbContext.Genres.Add(newGenre);
                            }
                        }
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