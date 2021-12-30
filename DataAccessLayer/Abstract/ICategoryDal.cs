using System.Collections.Generic;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        //Type Name();

        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);
    }
}