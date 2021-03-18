using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Station.Models
{
    public class Trip
    {
        private ICollection<User> users;

        public Trip()
        {
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Column("Starting Point")]
        public string Place1 { get; set; }

        [Column("Destination")]
        public string Place2 { get; set; }

        public int TrainId { get; set; }

        public Train Train { get; set; }

        public virtual ICollection<User> Users { get { return this.users; } set { this.users = value; } }
    }
}
