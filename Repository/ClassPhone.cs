using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassPhone : ClassNotify
    {
        public ClassPhone()
        {

        }
        [Key] //primaryKey
        public int PhoneId { get; set; }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value != _phone)
                {
                    _phone = value;
                    Notify("Phone");
                }
                
            }
        }

    }
}
