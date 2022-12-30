using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        //Authorize'ye roles verdiğimiz taktirde bu role ait kullanıcılar bunu görebiliyor
        // GET: AdminCategory
        [Authorize(Roles = "B")]
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [Authorize]
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult results = categoryvalidator.Validate(p);
            if(results.IsValid)
            {
            cm.CategoryAdd(p);
            return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [Authorize]
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetByID(id); 
            cm.CategoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue);
        }
        [Authorize]
        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }



    }
}