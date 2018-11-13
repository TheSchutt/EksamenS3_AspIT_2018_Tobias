using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity.ModelConfiguration;

namespace IOLayer
{
    public class MailEntityConfiguration : EntityTypeConfiguration<ClassMail>
    {
        public MailEntityConfiguration()
        {
            this.ToTable("Mail");

            this.HasKey<int>(m => m.MailId);

            this.Property(m => m.MailAddr).HasMaxLength(50).IsRequired();
        }
    }
}
