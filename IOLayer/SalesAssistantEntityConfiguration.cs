using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class SalesAssistantEntityConfiguration : EntityTypeConfiguration<ClassSaleAssistant>
    {
        public SalesAssistantEntityConfiguration()
        {
            this.ToTable("SaleAssistant");

            this.HasKey<int>(a => a.SaleAssistantId);

            this.Property(a => a.SaleAssistantName).HasMaxLength(50).IsRequired();

            
        }
    }
}
