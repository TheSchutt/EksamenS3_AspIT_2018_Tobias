using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repository;

namespace IOLayer
{
    public class OrderEntityConfiguration : EntityTypeConfiguration<ClassOrder>
    {
        public OrderEntityConfiguration()
        {
            this.ToTable("Order");
            this.HasKey<int>(o => o.OrderId);

            Property(p => p.OrderDate).IsRequired().HasColumnType("datetime2");
            Property(p => p.OrderPrice).IsRequired();
            Property(p => p.Weight).IsRequired();
            Property(p => p.SalePrice).IsRequired();
        }
    }
}
