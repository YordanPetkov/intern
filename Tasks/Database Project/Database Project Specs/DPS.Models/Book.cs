using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DPS.Models
{
    public class Book
    {
        public Book()
        {
            this.Genres = new HashSet<Genre>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int AuthorNicknameId { get; set; }
        public virtual AuthorNickname Author { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}