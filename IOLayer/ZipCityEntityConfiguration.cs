using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class ZipCityEntityConfiguration : EntityTypeConfiguration<ClassZipCIty>
    {
        public ZipCityEntityConfiguration()
        {
            this.ToTable("ZipCity");

            this.HasKey<string>(a => a.zipId);

            this.Property(a => a.CityName).HasMaxLength(50).IsRequired();
        }
    }
}
