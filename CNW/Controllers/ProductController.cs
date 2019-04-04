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
        public ActionResult View()
        {
            ProductModel context = new ProductModel();
            List<SanPham> model = context.accessDatabase;
            return PartialView(model);
        }
    }
}