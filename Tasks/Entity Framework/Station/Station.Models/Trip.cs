using System.Collections.Generic;

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
        public string Place1 { get; set; }
        public string Place2 { get; set; }

        public int TrainId { get; set; }
        public Train Train { get; set; }
        public virtual ICollection<User> Users { get { return this.users; } set { this.users = value; } }
    }

}
