using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DPS.Models
{
    public class AuthorNickname
    {
        public AuthorNickname()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual AuthorRealName Author { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}