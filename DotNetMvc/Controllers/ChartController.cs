using DotNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvc.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(),JsonRequestBehavior.AllowGet);
        }

        public List<Category> BlogList()
        {
            List<Category> ct = new List<Category>();
            ct.Add(new Category()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            ct.Add(new Category()
            {
                CategoryName = "Seyahat",
                CategoryCount = 20
            });
            ct.Add(new Category()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 1
            });
            ct.Add(new Category()
            {
                CategoryName = "Spor",
                CategoryCount = 6
            });

            return ct;
        }
    }
}