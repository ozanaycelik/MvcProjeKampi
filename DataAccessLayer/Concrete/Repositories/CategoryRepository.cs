using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        Context c = new Context();

        DbSet<Category> _object;

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
            //Save changes'in Klasik ado.net kullanımı nedir
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
