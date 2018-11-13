using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassMobile : ClassNotify
    {
        public ClassMobile()
        {

        }
        [Key]
        public int MobileId { get; set; }

        private string _mobile;

        public string Mobile
        {
            get { return _mobile; }
            set
            {
                if (value != _mobile)
                {
                    _mobile = value;
                    Notify("Mobile");
                }
                
            }
        }

    }
}
