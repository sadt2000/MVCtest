using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtest.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private NorthwindEntities db = new NorthwindEntities();
        public void Creat(Categories categories)
        {
            db.Categories.Add(categories);
            db.SaveChanges();
        }

        public void Delete(Categories categories)
        {
            db.Categories.Remove(categories);
            db.SaveChanges();
        }

        public IEnumerable<Categories> GetAll()
        {
            return db.Categories;
        }

        public Categories GetById(int id)
        {
          return  db.Categories.Find(id);
        }

        public void Update(Categories categories)
        {
            db.Entry(categories).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}