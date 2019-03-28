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
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {
            var results = new UserLoginModel().Login(user.username, user.password);
            if(results && ModelState.IsValid)
            {
                SessionHelper.setSession(new UserSesssion() { Username = user.username });
                return RedirectToAction("Home", "Index");
            }
            else
            {
                ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung");
            }
            return View(user);
        }
    }
}