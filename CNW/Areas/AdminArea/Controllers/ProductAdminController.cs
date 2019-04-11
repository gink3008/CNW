using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW.Models.Entities;
using CNW.Models;
using PagedList;
namespace CNW.Areas.AdminArea.Controllers
{
    public class ProductAdminController : Controller
    {
        // GET: AdminArea/Product
        public ActionResult Index(int page = 1, int pageSize = 5 )
        {
            IEnumerable<Product> product = new ProductF().accessDatabase.OrderByDescending(x => x.Name).ToPagedList(page,pageSize);
            ViewBag.Model = product;
            return View(product);
        }
        [HttpPost]
        public ActionResult Find(string str)
        {
            return View();
        }
        public void setViewBag(long? id = null)
        {
            IEnumerable<Species> model = new SpecciesF().accessDatabase;
            ViewBag.Species = new SelectList(model, "id", "Name", id);
        }
        public ActionResult Create()
        {
            IEnumerable<Species> model = new SpecciesF().accessDatabase;
            ViewBag.speciesID = new SelectList(model, "id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            ProductF productf = new ProductF();
            if (ModelState.IsValid)
            {
                productf.Insert(model);
                return RedirectToAction("Index","ProductAdmin");
            }
            IEnumerable<Species> specieslist = new SpecciesF().accessDatabase;
            ViewBag.speciesID = new SelectList(specieslist, "id", "Name");
            return View();
            
        }

        public ActionResult Details(string id)
        {
            Product product = new ProductF().FindProduct(id);
            return View(product);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            IEnumerable<Species> model = new SpecciesF().accessDatabase;
            ViewBag.speciesID = new SelectList(model, "id", "Name",id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                ProductF productF = new ProductF();
                productF.Update(model);
                return RedirectToAction("Index", "ProductAdmin");
            }
            IEnumerable<Species> specieslist = new SpecciesF().accessDatabase;
            ViewBag.speciesID = new SelectList(specieslist, "id", "Name",model.id);
            return View();

        }
        public ActionResult Delete(string id)
        {
            Product product = new ProductF().FindProduct(id);
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product product)
        {
            // phần xoá liên quan tới nhiều bảng khác anh em phải xoá các mấy bảng khác mới xoá được
             ProductF model = new ProductF();
             model.Delete(product.id);
             model.Save(); 
            return RedirectToAction("Index","ProductAdmin");
        }
    }
}