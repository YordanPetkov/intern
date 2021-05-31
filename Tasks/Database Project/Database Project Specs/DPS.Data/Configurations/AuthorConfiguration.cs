
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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