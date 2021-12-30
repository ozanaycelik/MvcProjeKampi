using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        /// <summary>
        /// id ye göre liste alma
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Content> GetListByHeadingID(int id);
        void ContentAdd(Content content);

        Content GetByID(int id);
        void ContentDelete(Content content);

        void ContentUpdate(Content content);
    }
}