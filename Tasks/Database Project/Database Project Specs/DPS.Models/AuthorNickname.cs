using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Models
{
    public class AuthorNickname
    {
        public AuthorNickname()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual AuthorRealName Author { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}