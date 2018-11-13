using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class CountryEntityConfiguration : EntityTypeConfiguration<ClassCountry>
    {
        public CountryEntityConfiguration()
        {
            this.ToTable("Country");

            this.HasKey<int>(a => a.CountryId);

            this.Property(a => a.CountryName).HasMaxLength(50).IsRequired();
        }
    }
}
