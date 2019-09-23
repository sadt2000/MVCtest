using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Models
{
    interface IGeneric<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void creat(T _categorie);
        void Update(T _categories);
        void Delete(T _categories);
    }
}
