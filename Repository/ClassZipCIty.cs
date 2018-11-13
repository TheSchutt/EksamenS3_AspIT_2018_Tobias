using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassZipCIty : ClassNotify
    {
        public ClassZipCIty()
        {

        }
        [Key]
        public string zipId { get; set; }

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set
            {
                if (value != _cityName)
                {
                    _cityName = value;
                    Notify("CityName");
                }
             
            }
        }

    }
}
