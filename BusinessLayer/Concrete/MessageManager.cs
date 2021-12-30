using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IRepository<Message> _messageDal;

        public MessageManager(IRepository<Message> messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetList()
        {
            return _messageDal.List();
        }
        public List<Message> GetListInbox()
        {
            return _messageDal.List(x=>x.ReceiverMail == "admin@gmail.com");
        }
        public List<Message> GetListSendbox()
        {
            return _messageDal.List(x=>x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message Message)
        {
            _messageDal.Insert(Message);
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public void MessageDelete(Message Message)
        {
            _messageDal.Delete(Message);
        }

        public void MessageUpdate(Message Message)
        {
            _messageDal.Update(Message);
        }
    }
}
