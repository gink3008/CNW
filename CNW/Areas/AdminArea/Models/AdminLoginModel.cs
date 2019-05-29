using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CNW.Models.Entities;

namespace CNW.Areas.AdminArea.Models
{
    public class AdminLoginModel
    {
        private Model1 context = null;
        public AdminLoginModel()
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
            var results = context.Database.SqlQuery<int>("admin_login @username, @password", sqlParams).SingleOrDefault();
            return results;
        }
        public bool checkUserName(string user)
        {
            return context.Customers.Count(x => x.id == user) > 0;
        }
    }
}