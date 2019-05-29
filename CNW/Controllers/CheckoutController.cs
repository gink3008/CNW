using CNW.Models;
using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addCheckout(Customer customer)
        {
            var cart = Session[CartSession];
            var model = (List<DetailBill>)cart;
            if (cart != null)
            {
                BillF billF = new BillF();
                Bill bill = new Bill();
                bill.id = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                bill.Date = DateTime.Now;
                bill.CustomerNameOnline = customer.Name;
                bill.CustomerAddressOnline = customer.Address;
                bill.CustomerPhoneOnline = customer.Phone;
                billF.Insert(bill);

                foreach(var item in model)
                {
                    DetailBill detailBill = new DetailBill();
                    detailBill.BiLLID = bill.id;
                    detailBill.quality = item.quality;
                    detailBill.ProductID = item.ProductID;
                    DetailBillF detailBillF = new DetailBillF();
                    detailBillF.Insert(detailBill);
                }
                return View("Index");
            }
            return View("Index");
        }
    }
}