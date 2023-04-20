using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetCategories();
        T GetCategory(int id);
        void AddCategory(T category);
        void RemoveCategory(T category);
        void UpdateCategory(T category);
    }
}
