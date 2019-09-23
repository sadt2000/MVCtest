using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCtest.Models
{
    public class Generic<T> : IGeneric<T> where T : class
    {

        NorthwindEntities db = null;
        DbSet<T> dbset = null;

        public Generic()
        {
            db = new NorthwindEntities();
            dbset = db.Set<T>();
        }

        public void creat(T _categorie)
        {
            dbset.Add(_categorie);
            db.SaveChanges();
        }

        public void Delete(T _categories)
        {
            dbset.Remove(_categories);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset;
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public void Update(T _categories)
        {
            db.Entry(_categories).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}