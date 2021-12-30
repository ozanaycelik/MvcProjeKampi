using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContentManager :IContentService
    {
        IRepository<Content> _contentDal;

        public ContentManager(IRepository<Content> contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        /// <summary>
        /// Heading IDye göre listeleme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
