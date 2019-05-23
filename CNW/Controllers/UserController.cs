using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Models;
using CNW.Models.Session;
using CNW.Models.Entities;
namespace CNW.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult IndexLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer user)
        {
            if(!ModelState.IsValid)
            {
                var results = new UserLoginModel().Login(user.id, user.password);
                if (results == 1)
                {
                    SessionHelper.setSession(new UserSesssion() { Username = user.id });
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung");
                }
                return View(user);
            }
            return View("IndexLogin");
            
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}