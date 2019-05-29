using CNW.Models;
using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(List<Image> model)
        {
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string search)
        {
            var model = new ProductImageF().accessDatabase.Where(x => String.Compare(x.ProductDetail.Product.Name,search) >= 0 && x.Official == true).ToList();
            if (model.Count > 0)
                return View("Index", model);
            return View("Index");
        }
        
    }
}