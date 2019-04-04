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
            ProductModel model = new ProductModel();
            IEnumerable<SanPham> sanPhams = model.accessDatabase;
            return View(sanPhams);
        }
    }
}