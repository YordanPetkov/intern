using DPS.Data;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic.DatabaseUtilities
{
    public static class GenreStore
    {
        public static void Create(CreationModel creationModel)
        {
            using (var dbContext = new LibraryDbContext())
            {
                foreach (var genre in creationModel.genres)
                {
                    dbContext.Genres.Add(new Genre
                    {
                        Name = genre.Name
                    });
                }
            }
        }
    }
}
