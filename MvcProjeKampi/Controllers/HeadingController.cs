﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading

        HeadingManager headingManager = new HeadingManager(new EFHeadingDal());
        CategoryManager categoryManager= new CategoryManager(new EFCategoryDal());
        WriterManager writerManager= new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var headingValues = headingManager.GetList();
            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            //dropdown List kontrolü
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString()
                    
                }).ToList();
            ViewBag.vlc = valueCategory;

            //dropdown List kontrolü
            List<SelectListItem> valueWriter = (from x in writerManager.GetList()
                select new SelectListItem
                {
                    Text = x.WriterName + " " + x.WriterSurName,
                    Value = x.WriterID.ToString()

                }).ToList();
            ViewBag.vlw = valueWriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString()

                }).ToList();
            ViewBag.vlc = valueCategory;

            var headingValue = headingManager.GetByID(id);

            return View(headingValue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {

            headingManager.HeadingUpdate(p);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var headingValue = headingManager.GetByID(id);
            headingValue.HeadingStatus = false;
            headingManager.HeadingDelete(headingValue);

            return RedirectToAction("Index");
        }
    }
}