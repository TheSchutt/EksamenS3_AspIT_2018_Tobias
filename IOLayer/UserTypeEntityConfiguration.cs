using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class UserTypeEntityConfiguration : EntityTypeConfiguration<ClassUserType>
    {
        public UserTypeEntityConfiguration()
        {
            this.ToTable("UserType");

            this.HasKey<int>(a => a.UserTypeId);

            this.Property(a => a.UserType).IsRequired();
        }
    }
}
