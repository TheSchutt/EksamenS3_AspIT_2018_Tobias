using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassValuta
    {
        public ClassValuta()
        {

        }
        [Key]
        public int ValutaId { get; set; }

        [ForeignKey("Country")] //Foregin key to the classCountry
        public int? CountryId { get; set; }
        public ClassCountry Country { get; set; }

        private string _valutaName;

        public string ValutaName
        {
            get { return _valutaName; }
            set { _valutaName = value; }
        }

    }
}
