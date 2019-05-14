using CNW.Models.Entities;
using CNW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;


namespace CNW.Areas.AdminArea.Controllers
{
    public class ImagesAdminController : Controller
    {
        // GET: AdminArea/ImagesAdmin
      public ActionResult Index(int page = 1, int pageSize = 5)
        {
            IEnumerable<Image> ProductImages = new ProductImageF().accessDatabase.OrderByDescending(x => x.url).ToPagedList(page, pageSize);
            ViewBag.Model = ProductImages;
            return View(ProductImages);
        }
        public ActionResult Create()
        {
            IEnumerable<Product> model = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(model, "id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Image model)
        {
            ProductImageF productImageF = new ProductImageF();
            if (ModelState.IsValid)
            {
                productImageF.Insert(model);
                return RedirectToAction("Index", "PDAdmin");
            }
            IEnumerable<Product> productlist = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(productlist, "id", "Name");
            return View();

        }
        public ActionResult Details(string id)
        {
            Image image = new ProductImageF().FindImage(id);
            return View(image);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            IEnumerable<Product> model = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(model, "id", "Name", id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Image model)
        {
            if (ModelState.IsValid)
            {
                ProductImageF productImageF = new ProductImageF();
                productImageF.Update(model);
                return RedirectToAction("Index", "PDAdmin");
            }
            IEnumerable<Product> productList = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(productList, "id", "Name", model.id);
            return View();

        }
        public ActionResult Delete(string id)
        {
            Image image = new ProductImageF().FindImage(id);
            return View(image);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Image images)
        {
            // phần xoá liên quan tới nhiều bảng khác anh em phải xoá các mấy bảng khác mới xoá được
            ProductImageF model = new ProductImageF();
            model.Delete(images);
            model.Save();
            return RedirectToAction("Index", "ProductAdmin");
        }
    }
}