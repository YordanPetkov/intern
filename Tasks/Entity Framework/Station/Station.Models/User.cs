using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Station.Models
{
    [Table("Passenger")]
    public class User
    {
        private ICollection<Trip> trips;

        public User()
        {
            this.trips = new HashSet<Trip>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Trip> Trips { get { return this.trips; } set { this.trips = value; } }
    }
}
