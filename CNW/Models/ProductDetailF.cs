using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class ProductDetailF
    {
        private Model1 context = null;
        public ProductDetailF()
        {
            context = new Model1();
        }
        public List<ProductDetail> accessDatabase
        {
            get { return context.ProductDetails.ToList(); }
        }
        public ProductDetail FindProductDetail(int ID)
        {
            return context.ProductDetails.Find(ID);
        }
        public bool Insert(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ID);
            if (dbProductDetail != null)
            {
                return false;
            }
            else
            {
                context.ProductDetails.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ID);
            if (dbProductDetail != null)
            {

            }

            return false;
        }
        public bool Delete(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ID);
            if (dbProductDetail != null)
            {
                context.ProductDetails.Remove(dbProductDetail);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}