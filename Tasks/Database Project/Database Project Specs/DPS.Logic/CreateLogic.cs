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
                    //List<string> tableNames = DatabaseLogic.GetTableNames();
                    //tableNames.RemoveAll(p => p == "__MigrationHistory");

                    //Console.WriteLine("To which table you want to add : (write the id of the table)");
                    //int tableId = MenuLogic.SelectTable(tableNames);

                    Console.WriteLine("Input the path of the JSON file :");
                    Console.Write("-");

                    string path = Console.ReadLine();

                    using (StreamReader r = new StreamReader(path))
                    {
                        string json = r.ReadToEnd();
                        var serializer = new JavaScriptSerializer();
                        var entities = serializer.Deserialize<JObject> (json);

                        foreach (var genre in entities)
                        {
                            Console.WriteLine(genre);
                        }
                        //dbContext.Genres.Add(JSONObj);
                        //dbContext.SaveChanges();



                        /*switch(tableNames[tableId])
                        {
                            case "Books":
                                Book newBook = serializer.Deserialize<Book>(json);
                                dbContext.Books.Add(newBook);
                                break;
                            case "AuthorNicknames":
                                AuthorNickname newNickname = serializer.Deserialize<AuthorNickname>(json);
                                dbContext.Nicknames.Add(newNickname);
                                break;
                            case "AuthorRealNames":
                                AuthorRealName newAuthor = serializer.Deserialize<AuthorRealName>(json);
                                dbContext.Authors.Add(newAuthor);
                                break;
                            case "Genres":
                                Genre newGenre = serializer.Deserialize<Genre>(json);
                                dbContext.Genres.Add(newGenre);
                                break;
                            default:
                                throw new Exception("Undefined table.");
                        }*/

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