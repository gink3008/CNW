using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models.Session
{
    public class SessionHelper
    {
        public static void setSession(UserSesssion userSesssion)
        {
            HttpContext.Current.Session["LoginSession"] = userSesssion;
        }
        public static UserSesssion GetSesssion()
        {
            var session = HttpContext.Current.Session["LoginSession"];
            if(session == null)
            {
                return null;
            }
            else
            {
                return session as UserSesssion;
            }
        }
    }
}