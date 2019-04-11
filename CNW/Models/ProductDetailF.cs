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
        public ProductDetail FindProductDetail(string id)
        {
            return context.ProductDetails.Find(id);
        }
        public bool Insert(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ProductID);
            if (dbProductDetail != null)
            {
                return false;
            }
            else
            {
                context.ProductDetails.Add(model);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ProductID);
            if (dbProductDetail != null)
            {
                dbProductDetail.ProductID = model.ProductID;
                dbProductDetail.Overview = model.Overview;
                dbProductDetail.Description = model.Description;
                dbProductDetail.Quality = model.Quality;
                dbProductDetail.Advertise = model.Advertise;
                context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool Delete(ProductDetail model)
        {
            ProductDetail dbProductDetail = context.ProductDetails.Find(model.ProductID);
            if (dbProductDetail != null)
            {
                context.ProductDetails.Remove(dbProductDetail);
                context.SaveChanges();
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}