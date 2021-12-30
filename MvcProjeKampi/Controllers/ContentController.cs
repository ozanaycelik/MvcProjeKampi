using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EFContentDal());
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult ContentByHeading(int id)
        {
            var contenValues = contentManager.GetListByHeadingID(id);
            
            return View(contenValues);
        }
    }
}