using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassSupllier : ClassNotify
    {
        public ClassSupllier()
        {

        }
        [Key] //primaryKey
        public int SupplierId { get; set; }

        private string _supplierName;

        public string SupplierName
        {
            get { return _supplierName; }
            set
            {
                if (value != _supplierName)
                {
                    _supplierName = value;
                    Notify("SupplierName");
                }
                
            }
        }

        private string _addresse;

        public string Addresse
        {
            get { return _addresse; }
            set
            {
                if (value != _addresse)
                {
                    _addresse = value;
                    Notify("Addresse");
                }
                
            }
        }


        [ForeignKey("Country")] //Foregin key to the classCountry
        public int? CountryId { get; set; }
        public ClassCountry Country { get; set; }

        [ForeignKey("Mail")] //Foregin key to the classMail
        public int? MailId { get; set; }
        public ClassMail Mail { get; set; }

        [ForeignKey("Phone")] //Foregin key to the classPhone
        public int? PhoneId { get; set; }
        public ClassPhone Phone { get; set; }
        
        
        [ForeignKey("zip")] //Foregin key to the classPhone
        public string zipId { get; set; }
        public ClassZipCIty zip { get; set; }

    }
}
