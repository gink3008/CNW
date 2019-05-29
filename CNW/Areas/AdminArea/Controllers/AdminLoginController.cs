using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Areas.AdminArea.Models;

namespace CNW.Areas.AdminArea.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminArea/AdminLogin
        public ActionResult IndexLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAdmin user)
        {
            if (ModelState.IsValid)
            {
                var results = new AdminLoginModel().Login(user.id, user.Password);
                if (results == 1)
                {
                    SessionHelper.SetSession(new AdminSession() { Username = user.id });
                    return Redirect("~/AdminArea/Admin/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung");
                }
                return View(user);
            }
            return View("IndexLogin");

        }
    }
}