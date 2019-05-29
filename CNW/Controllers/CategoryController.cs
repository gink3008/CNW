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
        public ActionResult Index(string id)
        {
            Category category = new CategoryF().Find(id);
            return View(category);
        }
        [ChildActionOnly]
        public ActionResult SlideBar()
        {
            IEnumerable<Category> model = new CategoryF().accessDatabase;
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult CategoryBody(string id)
        {

            var products = new ProductF().accessDatabase.ToList();
            var item = products.Where(x => x.Species.categoryID == id).ToList();
            if (item.Count > 0)
            {
                var model = item.Where(x => x.ProductDetail != null).ToList();
                if(model.Count > 0)
                {
                    return PartialView(model);
                }
            }
            else
            {
                var tryitem = products.Where(x => x.Species.id == id).ToList();
                var model = item.Where(x => x.ProductDetail != null).ToList();
                if (model.Count > 0)
                {
                    return PartialView(model);
                }
            }
            return PartialView();
        }
    }
}