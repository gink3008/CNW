using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class DetailBillF
    {
         private Model1 context = null;
        public DetailBillF()
        {
            context = new Model1();
        }
        public IQueryable<DetailBill> accessDatabase
        {
            get { return context.DetailBills; }
        }
        public DetailBill Find(int MaHD)
        {
            return context.DetailBills.Find(MaHD);
        }
        public bool Insert(DetailBill model)
        {
            DetailBill dbDetailBill = context.DetailBills.Find(model.BiLLID,model.ProductID);
            if (dbDetailBill != null)
            {
                return false;
            }
            else
            {
                context.DetailBills.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(DetailBill model)
        {
            DetailBill dbDetailBill = context.DetailBills.Find(model.BiLLID, model.ProductID);
            if (dbDetailBill != null)
            {
               

            }

            return false;
        }
        public bool Delete(DetailBill model)
        {
            DetailBill dbDetailBill = context.DetailBills.Find(model.BiLLID, model.ProductID);
            if (dbDetailBill != null)
            {
                context.DetailBills.Remove(dbDetailBill);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}