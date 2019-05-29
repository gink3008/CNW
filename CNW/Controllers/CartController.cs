using CNW.Models;
using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult showCart()
        {
            var cart = Session[CartSession];
            var list2 = (List<DetailBill>)cart;
            //IEnumerable<ProductDetail> listProductDetail = new ProductDetailF().accessDatabase;
            //List<ProductDetail> model = new List<ProductDetail>();
            //if (cart != null)
            //{
            //    var list = (List<DetailBill>)cart;
            //    foreach (var item in list)
            //    {
            //        var i = listProductDetail.Where(x => x.ProductID == item.ProductID).FirstOrDefault();
            //        model.Add(i);
            //    }
            //}
            return PartialView("showCart", list2);
        }
        public ActionResult AddCart(string productID, int quality)
        {
            var product = new ProductF().FindProduct(productID);
            var cart = Session[CartSession];
            if(cart != null)
            {
                var list = (List<DetailBill>)cart;
                if(list.Exists(x => x.ProductID == productID))
                {
                    foreach(var item in list)
                    {
                        if(item.ProductID == productID)
                        {
                            item.quality += quality;
                        }
                    }
                }
                else
                {
                    var item = new DetailBill();
                    item.Product = product;
                    item.ProductID = productID;
                    item.quality = quality;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                var item = new DetailBill();
                item.Product = product;
                item.ProductID = productID;
                item.quality = quality;
                var list = new List<DetailBill>();
                list.Add(item);
                Session[CartSession] = list;
                
            }
            return Redirect("Index");
        }
    }
}