using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
   public class ClassCountry : ClassNotify
    {
        public ClassCountry()
        {

        }
        [Key] //primaryKey
        public int CountryId { get; set; }

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set
            {
                if (value != _countryName)
                {
                    _countryName = value;
                    Notify("CountryName");
                }
            }
        }

    }
}
