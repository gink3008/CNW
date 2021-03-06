﻿using CNW.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CNW.Areas.AdminArea.Models;

namespace CNW.Areas.AdminArea.Models
{
    public class SessionHelper
    {
        public static void SetSession(AdminSession adminSession)
        {
            HttpContext.Current.Session["AdminLoginSession"] = adminSession;
        }
        public static UserSesssion GetSesssion()
        {
            var session = HttpContext.Current.Session["AdminLoginSession"];
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