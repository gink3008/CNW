using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Models;
using CNW.Models.Session;

namespace CNW.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserAdmin useradmin)
        {
            var results = new UserLoginModel().Login(useradmin.id, useradmin.Password);
            if(results && ModelState.IsValid)
            {
                SessionHelper.setSession(new UserSesssion() { Username = useradmin.id });
                return RedirectToAction("Home", "Index");
            }
            else
            {
                ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung");
            }
            return View(useradmin);
        }
    }
}