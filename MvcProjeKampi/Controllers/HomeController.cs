using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Tıklayınca geri dönüş değeri olan method türü
        /// ActionResult
        /// </summary>
        /// <returns>Geri dönüş değeri olarak bir sayfa dönüyor</returns>
        public ActionResult Test()
        {
            return View();

        }
    }
}