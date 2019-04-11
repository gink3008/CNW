using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models;
using CNW.Models.Entities;

namespace CNW.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeroSection()
        {
            ProductImageF productImageF = new ProductImageF();
            IEnumerable<Image> model = productImageF.accessDatabase;
            return PartialView(model);
        }
        public ActionResult HomeBody()
        {
            //ProductImageF productImageF = new ProductImageF();
            IEnumerable<ProductDetail> model = new ProductDetailF().accessDatabase;
            return PartialView(model);
        }
    }
}