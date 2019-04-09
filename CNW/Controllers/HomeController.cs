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
            ProductF model = new ProductF();
            IEnumerable<Product> sanPhams = model.accessDatabase;
            return View(sanPhams);
        }
        public ActionResult HeroSection()
        {
            ProductF productf = new ProductF();
            IEnumerable<Product> model = productf.accessDatabase;
            return PartialView(model);
        }
    }
}