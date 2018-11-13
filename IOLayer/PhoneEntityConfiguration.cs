using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity.ModelConfiguration;

namespace IOLayer
{
    public class PhoneEntityConfiguration : EntityTypeConfiguration<ClassPhone>
    {
        public PhoneEntityConfiguration()
        {
            this.ToTable("Phone");

            this.HasKey<int>(a => a.PhoneId);

            this.Property(a => a.Phone).HasMaxLength(50).IsRequired();
        }
    }
}
