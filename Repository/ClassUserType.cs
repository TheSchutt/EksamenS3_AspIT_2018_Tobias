using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
    public class ClassUserType
    {
        public ClassUserType()
        {

        }
        [Key] //primaryKey
        public int UserTypeId { get; set; }


        private int _userType;

        public int UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }

    }
}
