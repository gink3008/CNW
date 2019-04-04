using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class HoaDonModel
    {
        private Model1 context = null;
        public HoaDonModel()
        {
            context = new Model1();
        }
        public IQueryable<HoaDon> accessDatabase
        {
            get { return context.HoaDons; }
        }
        public HoaDon Find(int ID)
        {
            return context.HoaDons.Find(ID);
        }
        public bool Insert(HoaDon model)
        {
            HoaDon dbHoaDon = context.HoaDons.Find(model.id);
            if (dbHoaDon != null)
            {
                return false;
            }
            else
            {
                context.HoaDons.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(HoaDon model)
        {
            HoaDon dbHoaDon = context.HoaDons.Find(model.id);
            if (dbHoaDon != null)
            {
               

            }

            return false;
        }
        public bool Delete(HoaDon model)
        {
            HoaDon dbHoaDon = context.HoaDons.Find(model.id);
            if (dbHoaDon != null)
            {
                context.HoaDons.Remove(dbHoaDon);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}