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
        public IQueryable<SanPham> accessDatabase
        {
           get { return context.SanPhams;}
        }
        public SanPham FindSanPham(int MaSP)
        {
            return context.SanPhams.Find(MaSP);
        }
        public bool Insert(SanPham model)
        {
            SanPham dbSanPham = context.SanPhams.Find(model.id);
            if (dbSanPham.id != null)
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
    }
}