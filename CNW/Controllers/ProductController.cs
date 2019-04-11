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
        public ActionResult Index(string Id)
        {
            ProductDetail model = new ProductDetailF().FindProductDetail(Id);
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult Banner()
        {  
            //IEnumerable<ProductDetail> productDetails = new ProductDetailF().accessDatabase.Where(x => x.Images.)
            IEnumerable<Image> model = new ProductImageF().accessDatabase.Where(x => x.Official == true);
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult DetailProduct(string Id)
        {
            ProductDetail productDetail = new ProductDetailF().FindProductDetail(Id);
            return PartialView("DetailProduct", productDetail);
        }
        [ChildActionOnly]
        public ActionResult ImageProduct(string Id)//ProductDetail Pdetail)
        {
            //ProductDetail Pdetail = new ProductDetailF().accessDatabase.FirstOrDefault();
            IEnumerable<Image> model = new ProductImageF().accessDatabase.Where(x => x.ProductID == Id);
            return PartialView("ImageProduct", model);
        }
    }
}