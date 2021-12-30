using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HeadingManager :IHeadingService
    {
        IRepository<Heading> _headingDal;

        public HeadingManager(IRepository<Heading> headingDal)
        {
            _headingDal = headingDal;
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public void HeadingAdd(Heading Heading)
        {
            _headingDal.Insert(Heading);
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public void HeadingDelete(Heading Heading)
        {
            _headingDal.Update(Heading);
        }

        public void HeadingUpdate(Heading Heading)
        {
            _headingDal.Update(Heading);
        }
    }
}
