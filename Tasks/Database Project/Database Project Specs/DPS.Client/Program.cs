using DPS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new LibraryDbContext())
            {
                ctx.Authors.Add(
                    new Models.Author()
                    { FirstName = "Ivan", LastName = "Vazov" };

                )
            }
        }
    }
}
