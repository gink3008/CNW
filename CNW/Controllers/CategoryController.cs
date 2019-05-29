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
            //Category category = new CategoryF().Find(id);
            //return View(category);
            return View();
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

            var image = new ProductImageF().accessDatabase.Where(x => x.Official == true).ToList();
            var item = image.Where(x => x.ProductDetail.Product.Species.Category.id == id).ToList();
            if ( item.Count > 0)
            {
                var model = item.Where(x => x.ProductDetail != null).ToList();
                if(model.Count > 0)
                {
                    return PartialView(model);
                }
            }
            else
            {
                var tryitem = image.Where(x => x.ProductDetail.Product.Species.id == id).ToList();
                var model = tryitem.Where(x => x.ProductDetail != null).ToList();
                if (model.Count > 0)
                {
                    return PartialView(model);
                }
            }
            return PartialView();
        }
    }
}