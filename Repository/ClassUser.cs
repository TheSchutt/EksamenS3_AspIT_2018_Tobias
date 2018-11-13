using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
   public class ClassUser
    {
        public ClassUser()
        {

        }

        
        [Key]
        public int UserId {get; set;}


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [ForeignKey("Country")] //Foregin key to the classCountry
        public int CountryId { get; set; }
        public ClassCountry Country { get; set; }

        [ForeignKey("UserType")] //Foregin key to the classUserType
        public int UserTypeId { get; set; }
        public ClassUserType UserType { get; set; }

        [ForeignKey("Mail")] //Foregin key to the classMail
        public int MailId { get; set; }
        public ClassMail Mail { get; set; }

        [ForeignKey("Phone")] //Foregin key to the classPhone
        public int PhoneId { get; set; }
        public ClassPhone Phone { get; set; }

    }
}
