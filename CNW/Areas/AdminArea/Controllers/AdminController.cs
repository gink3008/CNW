using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Areas.AdminArea.Models;
using CNW.Models;

namespace CNW.Areas.AdminArea.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminArea/Index
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult SlideBar()
        {
            CategoryF categoryf = new CategoryF();
            IEnumerable<Category> model = categoryf.accessDatabase;
            return View(model);
        }
    }
}