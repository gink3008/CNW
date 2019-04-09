using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Models;
namespace CNW.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(ProductDetail Pdetail)
        {
            return View(Pdetail);
        }
        [ChildActionOnly]
        public ActionResult Banner()
        {
            ProductF context = new ProductF();
            List<Product> model = context.accessDatabase;
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult DetailProduct(ProductDetail Pdetail)
        {
            return PartialView("DetailProduct", Pdetail);
        }
        [ChildActionOnly]
        public ActionResult ImageProduct(ProductDetail Pdetail)
        {
            IEnumerable<Image> model = new ProductImageF().accessDatabase.Where(x => x.ProductID == Pdetail.ID);
            return PartialView("ImageProduct", model);
        }
    }
}