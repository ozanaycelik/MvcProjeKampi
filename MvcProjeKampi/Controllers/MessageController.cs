using System;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent_;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messageList= messageManager.GetListInbox();
            return View(messageList);
        }

        public ActionResult Sendbox()
        {
            var messageList = messageManager.GetListSendbox();
            return View(messageList);
        }

        public ActionResult Draftbox()
        {
            var messageList = messageManager.GetListSendbox();
            return View(messageList);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = messageManager.GetByID(id);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return RedirectToAction("Inbox");
        }

        
        [HttpPost]
        public ActionResult NewMessage(Message message,string buttonType)
        {
            switch (buttonType)
            {
                case "Draft":
                    message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    message.IsDraft = true;
                    messageManager.MessageAdd(message);
                    ViewBag.Message = "Customer saved successfully!";
                    break;
                case "Send":
                    message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    message.IsDraft = false;
                    messageManager.MessageAdd(message);
                    ViewBag.Message = "The operation was cancelled!";
                    break;
            }
            
            return RedirectToAction("Inbox");
        }
    }
}