using DPS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic
{
    public class DeleteLogic : IDeleteLogic
    {
        public DeleteLogic()
        {

        }

        public void DeleteData()
        {
            using(var dbContext = new LibraryDbContext())
            {
                
            }
        }
    }
}
