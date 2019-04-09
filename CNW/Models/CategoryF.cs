using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class CategoryF
    {
        private Model1 context = null;
        public CategoryF()
        {
            context = new Model1();
        }
        public IQueryable<Category> accessDatabase
        {
            get { return context.Categories; }
        }
        public Category Find(int MaHD)
        {
            return context.Categories.Find(MaHD);
        }
        public bool Insert(Category model)
        {
            Category dbCategory = context.Categories.Find(model.id);
            if (dbCategory != null)
            {
                return false;
            }
            else
            {
                context.Categories.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(Category model)
        {
            Category dbCategory = context.Categories.Find(model.id);
            if (dbCategory != null)
            {


            }

            return false;
        }
        public bool Delete(Category model)
        {
            Category dbCategory = context.Categories.Find(model.id);
            if (dbCategory != null)
            {
                context.Categories.Remove(dbCategory);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}