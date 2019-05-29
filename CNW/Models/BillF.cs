using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class BillF
    {
        private Model1 context = null;
        public BillF()
        {
            context = new Model1();
        }
        public IEnumerable<Bill> accessDatabase
        {
            get { return context.Bills; }
        }
        public Bill Find(int ID)
        {
            return context.Bills.Find(ID);
        }
        public bool Insert(Bill model)
        {
            Bill dbBill = context.Bills.Find(model.id);
            if (dbBill != null)
            {
                return false;
            }
            else
            {
                context.Bills.Add(model);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Bill model)
        {
            Bill dbBill = context.Bills.Find(model.id);
            if (dbBill != null)
            {
                dbBill.customerID = model.customerID;
                dbBill.CustomerNameOnline = model.CustomerNameOnline;
                dbBill.CustomerPhoneOnline = model.CustomerPhoneOnline;
                dbBill.CustomerGenerOnline = model.CustomerGenerOnline;
                dbBill.CustomerDateOnline = model.CustomerDateOnline;
                dbBill.Date = model.Date;
                context.SaveChanges();
                return true;

            }

            return false;
        }
        public bool Delete(Bill model)
        {
            Bill dbBill = context.Bills.Find(model.id);
            if (dbBill != null)
            {
                context.Bills.Remove(dbBill);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}