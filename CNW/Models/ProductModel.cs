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
        public List<SanPham> accessDatabase()
        {
            List<SanPham> exam = new List<SanPham>();
            return exam;
        }

    }
}