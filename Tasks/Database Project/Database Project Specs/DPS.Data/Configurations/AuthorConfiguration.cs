using DPS.Models;
using System.Data.Entity.ModelConfiguration;

namespace DPS.Data.Configurations
{
    public class AuthorConfiguration : EntityTypeConfiguration<AuthorRealName>
    {
        public AuthorConfiguration()
        {
            this.HasOptional(x => x.Nickname).WithRequired(x => x.Author);
        }
    }
}