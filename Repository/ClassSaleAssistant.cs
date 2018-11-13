using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassSaleAssistant : ClassNotify
    {
        public ClassSaleAssistant()
        {

        }
        [Key]
        public int SaleAssistantId { get; set; }

        private string _saleAssistantName;

        public string SaleAssistantName
        {
            get { return _saleAssistantName; }
            set
            {
                if (value != _saleAssistantName)
                {
                    _saleAssistantName = value;
                    Notify("SaleAssistantName");
                }
 
            }
        }

        [ForeignKey("Country")] //Foregin key to the classCountry
        public int CountryId { get; set; }
        public ClassCountry Country { get; set; }

        [ForeignKey("Supplier")] //Foregin key to the classGrainSupplier
        public int SupplierId { get; set; }
        public ClassSupllier Supplier { get; set; }

        [ForeignKey("Mail")] //Foregin key to the classMail
        public int MailId { get; set; }
        public ClassMail Mail { get; set; }

        [ForeignKey("Phone")] //Foregin key to the classPhone
        public int PhoneId { get; set; }
        public ClassPhone Phone { get; set; }

        [ForeignKey("Mobile")] //Foregin key to the classMobile
        public int MobileId { get; set; }
        public ClassMobile Mobile { get; set; }
    }
}
