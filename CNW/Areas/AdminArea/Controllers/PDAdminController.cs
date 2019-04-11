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
    public class PDAdminController : Controller
    {
        // GET: AdminArea/ProductDetail
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            IEnumerable<ProductDetail> productdetails = new ProductDetailF().accessDatabase.OrderByDescending(x => x.Product.Name).ToPagedList(page, pageSize);
            ViewBag.Model = productdetails;
            return View(productdetails);
        }
        public ActionResult Create()
        {
            IEnumerable<Product> model = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(model, "id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductDetail model)
        {
            ProductDetailF productdetailf = new ProductDetailF();
            if (ModelState.IsValid)
            {
                productdetailf.Insert(model);
                return RedirectToAction("Index", "PDAdmin");
            }
            IEnumerable<Product> productlist = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(productlist, "id", "Name");
            return View();

        }
        public ActionResult Details(string id)
        {
            ProductDetail product = new ProductDetailF().FindProductDetail(id);
            return View(product);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            IEnumerable<Product> model = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(model, "id", "Name", id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(ProductDetail model)
        {
            if (ModelState.IsValid)
            {
                ProductDetailF productDetailF = new ProductDetailF();
                productDetailF.Update(model);
                return RedirectToAction("Index", "PDAdmin");
            }
            IEnumerable<Product> productList = new ProductF().accessDatabase;
            ViewBag.ProductID = new SelectList(productList, "id", "Name", model.Id);
            return View();

        }
        public ActionResult Delete(string id)
        {
            ProductDetail productDetail = new ProductDetailF().FindProductDetail(id);
            return View(productDetail);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProductDetail productDetail)
        {
            // phần xoá liên quan tới nhiều bảng khác anh em phải xoá các mấy bảng khác mới xoá được
            ProductDetailF model = new ProductDetailF();
            model.Delete(productDetail);
            model.Save();
            return RedirectToAction("Index", "ProductAdmin");
        }
    }
}