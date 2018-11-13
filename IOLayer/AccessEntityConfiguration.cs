using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class AccessEntityConfiguration : EntityTypeConfiguration<ClassAccess>
    {
        public AccessEntityConfiguration()
        {
            this.ToTable("Access");

            this.HasKey<int>(a => a.AccessId);

            this.Property(a => a.cprNr).HasMaxLength(50).IsRequired();

            this.Property(a => a.passWord).HasMaxLength(50).IsRequired();


        }
    }
}
