using MvcProjeKampi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi1.Controllers
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
            return Json(BlokList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlokList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                Categoryname = "Yazılım",
                CategorCount = 8
            });
            ct.Add(new CategoryClass()
            {
                Categoryname = "Seyehat",
                CategorCount = 4
            }); ct.Add(new CategoryClass()
            {
                Categoryname = "Teknoloji",
                CategorCount = 7
            }); ct.Add(new CategoryClass()
            {
                Categoryname = "Spor",
                CategorCount = 1
            });
            return ct;
        }
    }
}