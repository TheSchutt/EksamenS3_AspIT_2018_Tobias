using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class ValutaEntityConfiguration : EntityTypeConfiguration<ClassValuta>
    {
        public ValutaEntityConfiguration()
        {
            this.ToTable("Valuta");

            this.HasKey<int>(a => a.ValutaId);

            this.Property(a => a.ValutaName).HasMaxLength(50).IsRequired();
        }
    }
}
