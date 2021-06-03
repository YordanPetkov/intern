using System.ComponentModel.DataAnnotations.Schema;

namespace DPS.Models
{
    public class AuthorRealName
    {
        public AuthorRealName()
        {

        }

        [ForeignKey("Nickname")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int NicknameId { get; set; }
        public AuthorNickname Nickname { get; set; }
    }
}