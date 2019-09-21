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
            throw new NotImplementedException();
        }

        public void Delete(Categories categories)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories categories)
        {
            throw new NotImplementedException();
        }
    }
}