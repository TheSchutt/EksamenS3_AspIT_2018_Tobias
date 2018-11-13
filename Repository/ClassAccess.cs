using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassAccess : ClassNotify
    {
        public ClassAccess()
        {

        }
        [Key]
        public int AccessId { get; set; }

        [ForeignKey("User")] //Foregin key to the classUser
        public int UserId { get; set; }
        public ClassUser User { get; set; }

        private string _cprNr;

        public string cprNr
        {
            get { return _cprNr; }
            set
            {
                if (value != _cprNr)
                {
                    _cprNr = value;                    
                    
                }
            }
        }
        private string _passWord;
        public string passWord
        {
            get { return _passWord; }
            set
            {
                if (value != _passWord)
                {
                    _passWord = value;
                    
                }
            }
        }

    }
}
