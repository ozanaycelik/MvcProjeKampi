using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent_;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
     
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EFContactDal());
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        ContactValidator ContactValidator = new ContactValidator();

        public ActionResult Index()
        {
            var contactValues = contactManager.GetList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetByID(id);
            return View(contactValues);
        }

        public PartialViewResult ContactPartial()
        {
            var messageList = messageManager.GetList();
            return PartialView(messageList);
        }
    }
}