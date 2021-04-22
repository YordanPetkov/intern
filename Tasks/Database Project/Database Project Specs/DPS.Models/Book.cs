using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Models
{
    public class Book
    {
        public Book()
        {
            this.Genres = new HashSet<Genre>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }

    }
}
