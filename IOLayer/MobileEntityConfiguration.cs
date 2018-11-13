using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity.ModelConfiguration;

namespace IOLayer
{
    public class MobileEntityConfiguration : EntityTypeConfiguration<ClassMobile>
    {
        public MobileEntityConfiguration()
        {
            this.ToTable("Mobile");

            this.HasKey<int>(a => a.MobileId);

            this.Property(a => a.Mobile).HasMaxLength(50).IsRequired();
        }
    }
}
