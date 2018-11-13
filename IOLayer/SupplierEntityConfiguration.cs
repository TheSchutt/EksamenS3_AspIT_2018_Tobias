using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity.ModelConfiguration;

namespace IOLayer
{
    public class SupplierEntityConfiguration : EntityTypeConfiguration<ClassSupllier>
    {
        public SupplierEntityConfiguration()
        {
            this.ToTable("Supplier");

            this.HasKey<int>(a => a.SupplierId);

            this.Property(a => a.SupplierName).HasMaxLength(50).IsRequired();
        }
    }
}
