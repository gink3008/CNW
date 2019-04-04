using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class LoaiSPModel
    {
        private Model1 context = null;
        public LoaiSPModel()
        {
            context = new Model1();
        }
        public IQueryable<Loaisp> accessDatabase
        {
            get { return context.Loaisps; }
        }
        public Loaisp FindLoaisp(int ID)
        {
            return context.Loaisps.Find(ID);
        }
        public bool Insert(Loaisp model)
        {
            Loaisp dbLoaisp = context.Loaisps.Find(model.id);
            if (dbLoaisp != null)
            {
                return false;
            }
            else
            {
                context.Loaisps.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(Loaisp model)
        {
            Loaisp dbLoaisp = context.Loaisps.Find(model.id);
            if (dbLoaisp != null)
            {
                dbLoaisp.Name = model.Name;

            }

            return false;
        }
        public bool Delete(Loaisp model)
        {
            Loaisp dbLoaisp = context.Loaisps.Find(model.id);
            if (dbLoaisp != null)
            {
                context.Loaisps.Remove(dbLoaisp);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}