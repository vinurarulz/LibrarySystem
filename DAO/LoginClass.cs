using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class LoginClass
    {
        public bool LoginUser(string us, string pw)
        {
            try
            {
                using (var db = new LibraryDBEntities())
                {
                    var q = from p in db.Logins
                            where p.UserName == us
                            && p.Pwd == pw
                            select p;

                    if (q.Any())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
