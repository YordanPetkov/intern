using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DPS.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}