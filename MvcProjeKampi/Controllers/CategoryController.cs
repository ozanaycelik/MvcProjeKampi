using System.Web.Mvc;
using System.Web.WebSockets;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent_;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = categoryManager.GetList();

            return View(categoryValues);
        }

        /// <summary>
        /// Sayfayı döndürmesini istiyoruz.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        /// <summary>
        /// Sayfa yüklendiğinde çalışmasını engeller post olduğunda
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //categoryManager.CategoryAddBL(p);

            // Kayıt öncesi yapılan kontrol
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);

            if (results.IsValid)
            {
                categoryManager.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            //Ekleme işlemi yapıldıktan sonra başka metodu çağırıyoruz!
            //return RedirectToAction("GetCategoryList");
            return View();
        }
    }
}