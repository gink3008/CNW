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
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Banner()
        {
            ProductF context = new ProductF();
            List<Product> model = context.accessDatabase;
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult DetailProduct()
        {
            ProductDetailF detail = new ProductDetailF();
            IEnumerable<ProductDetail> model = detail.accessDatabase;
            return PartialView("DetailProduct",model);
        }
        [ChildActionOnly]
        public ActionResult ImageProduct()
        {
            ProductImageF image = new ProductImageF();
            IEnumerable<Image> model = image.accessDatabase;
            return PartialView("ImageProduct",model);
        }
    }
}