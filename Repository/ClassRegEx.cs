using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassRegEx
    {
        public ClassRegEx()
        {

        }

        public bool IsValidDKPhoneNumber(string checkValue)
        {
            string pattern = @"^(((\(\+45\))|(0045))\s?)?(([0-9]{8}){1})|(([0-9]{2}\s){4})|(([0-9]{2}\s?){1})(([0-9]{3}\s?){2})$";
            return Regex.IsMatch(checkValue, pattern);
        }

        public bool IsValidDkSocialSecurityNumber(string checkValue)
        {
            bool isValid;
            string pattern = @"^(?:(?:31(?:0[13578]|1[02])|(?:30|29)(?:0[13-9]|1[0-2])|(?:0[1-9]|1[0-9]|2[0-8])(?:0[1-9]|1[0-2]))[0-9]{2}(\s?|\-?)[0-9]|290200-?[4-9]|2902(?:(?!00)[02468][048]|[13579][26])(\s{0,1}|\-{0,1})[0-3])[0-9]{3}|000000(\s?|\-?)0000$";
            isValid = Regex.IsMatch(checkValue, pattern);
            //isValid = CheckCpr(checkValue);
            return isValid;
        }
        public bool ValidateEmail(string email)
        {
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success == true)
                return true;
            else
                return false;
        }


    }
}
