using DPS.Data;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic.DatabaseUtilities
{
    public static class AuthorStore
    {
        public static void Create(CreationModel creationModel)
        {
            using (var dbContext = new LibraryDbContext())
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
        }
    }
}
