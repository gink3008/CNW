using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        [HttpPost]
        public ActionResult Register(User model)
        {
            if (!ModelState.IsValid)
            {
                var dao = new UserLoginModel();
                if (dao.checkUserName(model.id))
                {
                    ModelState.AddModelError("", "Ten dang nhap da ton tai");
                }
                else
                {
                    var customer = new Customer();
                    customer.id = model.id;
                    customer.Name = model.Name;
                    customer.password = model.password;
                    customer.Phone = model.Phone;
                    customer.Sex = model.Sex;
                    var result = dao.Insert(customer);
                    if (result)
                    {
                        ViewBag.Success = "Dang ky thanh cong";
                    }
                    else
                    {
                        ModelState.AddModelError("", "Dang ky khong thanh cong");
                    }

                }
            }
            else
                return View(model);
            return View(model);
        }

    }
}