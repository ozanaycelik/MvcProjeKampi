using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetList();

        void MessageAdd(Message message);

        Message GetByID(int id);
        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}