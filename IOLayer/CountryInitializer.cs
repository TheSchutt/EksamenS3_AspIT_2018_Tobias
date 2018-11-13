using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Data.Entity;

namespace IOLayer
{
    public class CountryInitializer : DropCreateDatabaseIfModelChanges<GrainContext>
    {
        protected override void Seed(GrainContext context)
        {
            IList<ClassCountry> defualtCountry = new List<ClassCountry>();
            defualtCountry.Add(new ClassCountry() { CountryName = "Denmark" });
            defualtCountry.Add(new ClassCountry() { CountryName = "Germany" });
            defualtCountry.Add(new ClassCountry() { CountryName = "Sweden" });
            defualtCountry.Add(new ClassCountry() { CountryName = "Norway" });
            defualtCountry.Add(new ClassCountry() { CountryName = "France" });
            defualtCountry.Add(new ClassCountry() { CountryName = "Canada" });
            foreach (ClassCountry Country in defualtCountry)
                context.Country.Add(Country);

            base.Seed(context);
        }
    }
}
