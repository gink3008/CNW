using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CNW.Models.Entities;
namespace CNW.Models
{
    public class ProductModel
    {
        private Model1 context = null;
        public ProductModel()
        {
            context = new Model1();
        }
        public List<SanPham> accessDatabase
        {
           get { return context.SanPhams.ToList();}
        }
        public SanPham FindSanPham(int ID)
        {
            return context.SanPhams.Find(ID);
        }
        public bool Insert(SanPham model)
        {
            SanPham dbSanPham = context.SanPhams.Find(model.id);
            if (dbSanPham != null)
            {
                return false;
            }
            else
            {
                context.SanPhams.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(SanPham model)
        {
            SanPham dbSanPham = context.SanPhams.Find(model.id);
            if (dbSanPham != null)
            {
                dbSanPham.Name = model.Name;

            }
         
            return false;
        }
        public bool Delete(SanPham model)
        {
            SanPham dbSanPham = context.SanPhams.Find(model.id);
            if (dbSanPham != null)
            {
                context.SanPhams.Remove(dbSanPham);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}