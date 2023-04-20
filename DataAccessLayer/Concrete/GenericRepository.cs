using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        
        public void AddCategory(T category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
        }

        public List<T> GetCategories()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T GetCategory(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public void RemoveCategory(T category)
        {
            using var c = new Context();
            c.Remove(category);
            c.SaveChanges();
        }

        public void UpdateCategory(T category)
        {
            using var c = new Context();
            c.Update(category);
            c.SaveChanges();
        }
    }
}
