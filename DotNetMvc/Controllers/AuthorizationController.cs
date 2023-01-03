using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvc.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager amanager = new AdminManager(new EfAdminDal());

        // GET: Authorization
        public ActionResult Index()
        {
            var adminvalues = amanager.GetList();

            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            amanager.AdminAdd(p);
            return RedirectToAction("Index");
        }


    }
}