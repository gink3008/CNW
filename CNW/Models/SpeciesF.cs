using CNW.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW.Models
{
    public class SpecciesF
    {
        private Model1 context = null;
        public SpecciesF()
        {
            context = new Model1();
        }
        public IQueryable<Species> accessDatabase
        {
            get { return context.Species; }
        }
        public Species FindSpecies(string ID)
        {
            return context.Species.Find(ID);
        }
        public bool Insert(Species model)
        {
            Species dbSpecies = context.Species.Find(model.id);
            if (dbSpecies != null)
            {
                return false;
            }
            else
            {
                context.Species.Add(model);
                return true;
            }
            return false;
        }
        public bool Update(Species model)
        {
            Species dbSpecies = context.Species.Find(model.id);
            if (dbSpecies != null)
            {
                dbSpecies.Name = model.Name;

            }

            return false;
        }
        public bool Delete(Species model)
        {
            Species dbSpecies = context.Species.Find(model.id);
            if (dbSpecies != null)
            {
                context.Species.Remove(dbSpecies);
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}