using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class ProductImageF
    {
        private Model1 context = null;
        public ProductImageF()
        {
            context = new Model1();
        }
        public List<Image> accessDatabase
        {
            get { return context.Images.ToList(); }
        }
        public Image FindImage(int ID)
        {
            return context.Images.Find(ID);
        }
        public bool Insert(Image model)
        {
            Image dbImage = context.Images.Find(model.id);
            if (dbImage != null)
            {
                return false;
            }
            else
            {
                context.Images.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(Image model)
        {
            Image dbImage = context.Images.Find(model.id);
            if (dbImage != null)
            {
                dbImage.url = model.url;
            }

            return false;
        }
        public bool Delete(Image model)
        {
            Image dbImage = context.Images.Find(model.id);
            if (dbImage != null)
            {
                context.Images.Remove(dbImage);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}