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

        public void CreateData(string path)
        {
            using (var dbContext = new LibraryDbContext())
            {
                try
                {
                    List<string> tableNames = DatabaseLogic.GetTableNames();

                    using (StreamReader reader = new StreamReader(path))
                    {
                        string json = reader.ReadToEnd();

                        CreationModel creationModel = JsonConvert.DeserializeObject<CreationModel>(json);

                        if(!(creationModel.genres is null))
                        {
                            GenreStore.Create(creationModel);
                        }
                        
                        if(!(creationModel.nicknames is null))
                        {
                            NicknameStore.Create(creationModel);
                        }
                        
                        if(!(creationModel.authors is null))
                        {
                            AuthorStore.Create(creationModel);
                        }
                        
                        if(!(creationModel.books is null))
                        {
                            BookStore.Create(creationModel);
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