using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CNW.Models.Entities;

namespace CNW.Models
{
    public class UserLoginModel
    {
        private Model1 context = null;
        public UserLoginModel()
        {
            context = new Model1();
        }
        public int Login(string username, string password)
        {
            object[] sqlParams = new SqlParameter[]
            {
            new SqlParameter("@username",username),
            new SqlParameter("@password",password),
            };
            var results = context.Database.SqlQuery<int>("users_login @username, @password", sqlParams).SingleOrDefault();
            return results;
    }
    }
}