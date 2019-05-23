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
        public bool Insert(Customer model)
        {
            Customer dbCustomer = context.Customers.Find(model.id);
            if (dbCustomer != null)
            {
                return false;
            }
            else
            {
                context.Customers.Add(model);
                context.SaveChanges();
                return true;
            }
            return false;
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
        public bool checkUserName (string user)
        {
            return context.Customers.Count(x => x.id == user) > 0;
        }
    }
}