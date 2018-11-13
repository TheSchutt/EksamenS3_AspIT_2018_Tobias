using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity.ModelConfiguration;

namespace IOLayer
{
    public class GrainSortEntityConfiguration : EntityTypeConfiguration<ClassGrainSort>
    {
        public GrainSortEntityConfiguration()
        {
            this.ToTable("GrainSort");

            this.HasKey<int>(a => a.GrainSortId);

            this.Property(a => a.GrainSort).HasMaxLength(20);
        }
    }
}
