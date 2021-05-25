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
    public class OldCreateLogic : ICreateLogic
    {
        public OldCreateLogic()
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
                        var fieldsCollector = new JsonLogic(jsonObject);
                        var fields = fieldsCollector.GetAllFields();
                        var JSONObj = new JavaScriptSerializer().Deserialize<Genre>(json);
                        //dbContext.Genres.Add(JSONObj);
                        //dbContext.SaveChanges();

                        foreach (var field in fields)
                        {
                            Console.WriteLine($"{field.Key}: '{field.Value}'");
                        }
                        /*foreach (var item in array)
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
                                //JObject newGenre = JsonConvert.DeserializeObject<Genre>(item.Genre);
                                dynamic newg = JsonConvert.DeserializeObject(item.ToString());
                                Console.WriteLine(newg);
                                Console.WriteLine(newGenre["Id"]);
                                Console.WriteLine(newGenre["Name"]);
                                dbContext.Genres.Add(newGenre.ToObject<Genre>());
                            }
                        }*/
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