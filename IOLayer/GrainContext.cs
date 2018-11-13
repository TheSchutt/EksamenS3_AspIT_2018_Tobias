using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace IOLayer
{
    public class GrainContext : DbContext
    {
        public GrainContext() : base("GrainBarrelDB")
        {            
            Database.SetInitializer(new CountryInitializer());
            
        }

        /// <summary>
        /// Gets or Sets the dbset of ClassOrder
        /// </summary>
        public DbSet<ClassOrder> Order { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassAccess
        /// </summary>
        public DbSet<ClassAccess> Access { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassCountry
        /// </summary>
        public DbSet<ClassCountry> Country { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassGrainSort
        /// </summary>
        public DbSet<ClassGrainSort> GrainSort { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassMobile
        /// </summary>
        public DbSet<ClassMobile> Mobile { get; set; }
        /// <summary>
        /// Gets or Sets the dbset of ClassMail
        /// </summary>
        public DbSet<ClassMail> Mail { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassPhone
        /// </summary>
        public DbSet<ClassPhone> Phone { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassSaleAssistant
        /// </summary>
        public DbSet<ClassSaleAssistant> SaleAssistant { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassSupllier
        /// </summary>
        public DbSet<ClassSupllier> Supplier { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassUser
        /// </summary>
        public DbSet<ClassUser> User { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassUserType
        /// </summary>
        public DbSet<ClassUserType> UserType { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassValuta
        /// </summary>
        public DbSet<ClassValuta> Valuta { get; set; }

        /// <summary>
        /// Gets or Sets the dbset of ClassZipCity
        /// </summary>
        public DbSet<ClassZipCIty> ZipCity { get; set; }

        /// <summary>
        /// Overrides the OnModleCreating to allow the use of fluent api
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccessEntityConfiguration());
            modelBuilder.Configurations.Add(new CountryEntityConfiguration());
            modelBuilder.Configurations.Add(new GrainSortEntityConfiguration());
            modelBuilder.Configurations.Add(new MailEntityConfiguration());
            modelBuilder.Configurations.Add(new MobileEntityConfiguration());
            modelBuilder.Configurations.Add(new OrderEntityConfiguration());
            modelBuilder.Configurations.Add(new PhoneEntityConfiguration());
            modelBuilder.Configurations.Add(new SalesAssistantEntityConfiguration());
            modelBuilder.Configurations.Add(new SupplierEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new UserTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new ValutaEntityConfiguration());
            modelBuilder.Configurations.Add(new ZipCityEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
