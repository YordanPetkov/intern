using Station.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Station.Data
{
    public class StationDBContext : DbContext
    {
        public StationDBContext()
            : base("name = StationDBConnectionString")
        {

        }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
