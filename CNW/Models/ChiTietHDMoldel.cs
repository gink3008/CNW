using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class ChiTietHDMoldel
    {
         private Model1 context = null;
        public ChiTietHDMoldel()
        {
            context = new Model1();
        }
        public IQueryable<ChiTietHD> accessDatabase
        {
            get { return context.ChiTietHDs; }
        }
        public ChiTietHD Find(int MaHD)
        {
            return context.ChiTietHDs.Find(MaHD);
        }
        public bool Insert(ChiTietHD model)
        {
            ChiTietHD dbChiTietHD = context.ChiTietHDs.Find(model.HoaDonID,model.SanPhamID);
            if (dbChiTietHD != null)
            {
                return false;
            }
            else
            {
                context.ChiTietHDs.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(ChiTietHD model)
        {
            ChiTietHD dbChiTietHD = context.ChiTietHDs.Find(model.HoaDonID, model.SanPhamID);
            if (dbChiTietHD != null)
            {
               

            }

            return false;
        }
        public bool Delete(ChiTietHD model)
        {
            ChiTietHD dbChiTietHD = context.ChiTietHDs.Find(model.HoaDonID, model.SanPhamID);
            if (dbChiTietHD != null)
            {
                context.ChiTietHDs.Remove(dbChiTietHD);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}