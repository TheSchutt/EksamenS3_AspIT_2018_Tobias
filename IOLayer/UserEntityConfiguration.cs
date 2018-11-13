using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class UserEntityConfiguration : EntityTypeConfiguration<ClassUser>
    {
        public UserEntityConfiguration()
        {
            this.ToTable("User");

            this.HasKey<int>(a => a.UserId);

            this.Property(a => a.Name).HasMaxLength(50).IsRequired();
        }
    }
}
