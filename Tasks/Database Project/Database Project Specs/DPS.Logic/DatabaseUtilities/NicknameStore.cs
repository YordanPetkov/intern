using DPS.Data;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic.DatabaseUtilities
{
    public static class NicknameStore
    {
        public static void Create(CreationModel creationModel)
        {
            using (var dbContext = new LibraryDbContext())
            {
                foreach (var nickname in creationModel.nicknames)
                {
                    dbContext.Nicknames.Add(new AuthorNickname
                    {
                        Name = nickname.Name
                    });
                }
            }
        }
    }
}
