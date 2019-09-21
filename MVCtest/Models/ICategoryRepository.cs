using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Models
{
  public interface ICategoryRepository
    {
        Categories GetById(int id);
        IEnumerable<Categories> GetAll();
        void Creat(Categories categories);
        void Update(Categories categories);
        void Delete(Categories categories);

    }
}
