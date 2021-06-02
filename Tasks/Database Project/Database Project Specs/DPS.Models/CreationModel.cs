using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Models
{
    public class CreationModel
    {
        public CreationModel()
        {
                
        }

        public Book[] books { get; set; }
        public Genre[] genres { get; set; }
        public AuthorRealName[] authors { get; set; }
        public AuthorNickname[] nicknames { get; set; }
    }
}
