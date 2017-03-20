using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Framework;
using System.Data.SqlClient;

namespace Model
{
    public class UserModel
    {
        private APMTDbContext context = null;
        public UserModel()
        {
            context = new APMTDbContext();
        }
        public bool Login(string email,string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@Email",email),
                new SqlParameter("@Password",password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_User_Login @Email,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
