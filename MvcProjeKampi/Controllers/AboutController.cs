using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        
        public ActionResult Index()
        {
            var aboutValues = aboutManager.GetList();
            return View(aboutValues);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            aboutManager.AboutAdd(about);
            return RedirectToAction("Index");
        }

        public PartialViewResult AboutPartial()
        {

            return PartialView();
        }
    }
}