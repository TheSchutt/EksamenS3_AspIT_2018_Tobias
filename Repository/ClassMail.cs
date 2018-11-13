using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class ClassMail : ClassNotify
    {
        public ClassMail()
        {

        }
        [Key] //primaryKey
        public int MailId { get; set; }

        private string _mailAddr;

        public string MailAddr
        {
            get { return _mailAddr; }
            set
            {
                if (value != _mailAddr)
                {
                    _mailAddr = value;
                    Notify("MailAddr");
                }
                
            }
        }

    }
}
