using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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

        public string ToJson()
        {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(this);

            return json;
        }
    }
}