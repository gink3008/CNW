using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CNW.Models.Entities;
namespace CNW.Models
{
    public class ProductF
    {
        private Model1 context = null;
        public ProductF()
        {
            context = new Model1();
        }
        public List<Product> accessDatabase
        {
           get { return context.Products.ToList();}
        }
        public Product FindProduct(string ID)
        {
            return context.Products.Find(ID);
        }
        public bool Insert(Product model)
        {
            Product dbProduct = context.Products.Find(model.id);
            if (dbProduct != null)
            {
                return false;
            }
            else
            {
                context.Products.Add(model);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Product model)
        {
            Product dbProduct = context.Products.Find(model.id);
            if (dbProduct != null)
            {
                dbProduct.Name = model.Name;
                context.SaveChanges();
                return true;
            }
         
            return false;
        }
        public bool Delete(string id)
        {
            Product dbProduct = context.Products.Find(id);
            if (dbProduct != null)
            {
                context.Products.Remove(dbProduct);
                context.SaveChanges();
            }
            return false;
        }
        public void Save()
        {
            
        }
    }
}