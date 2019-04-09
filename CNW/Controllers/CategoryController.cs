using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Models;
namespace CNW.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {

            return View();
        }
        [ChildActionOnly]
        public ActionResult SlideBar()
        {
            IEnumerable<Category> model = new CategoryF().accessDatabase;
            return PartialView(model);
        }
    }
}