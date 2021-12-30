using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();

        void AboutAdd(About about);

        About GetByID(int id);
        void AboutDelete(About about);

        void AboutUpdate(About about);
    }
}