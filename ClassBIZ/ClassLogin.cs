using IOLayer;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBIZ
{
    public class ClassLogin
    {
        public ClassLogin()
        {

        }
        public ClassUser Login(string username, string password)
        {
            ClassUser us = new ClassUser();
            try
            {
                using (var ctx = new GrainContext())
                {
                    us = ctx.Database.SqlQuery<ClassUser>("SELECT dbo.[User].UserId, dbo.[User].Name, dbo.[User].CountryId, dbo.[User].UserTypeId, dbo.[User].MailId, dbo.[User].PhoneId " +
                         "FROM dbo.Access LEFT OUTER JOIN dbo.[User] ON dbo.Access.UserId = dbo.[User].UserId " +
                         "WHERE (dbo.Access.passWord = N'" + password + "') AND (dbo.Access.cprNr = N'" + username + "')").FirstOrDefault<ClassUser>();
                    if (us == null)
                    {
                        us = new ClassUser();
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return us;
        }
    }
}
