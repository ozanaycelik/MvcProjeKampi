using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent_;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                categoryManager.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        
        /// <summary>
        /// Silme işlemi / İlişkili tablolarda silme işlemi yapmıyoruz!
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = categoryManager.GetByID(id);
            categoryManager.CategoryDelete(categoryValue);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValue = categoryManager.GetByID(id);
            return View(categoryValue);
        }
        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            categoryManager.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}