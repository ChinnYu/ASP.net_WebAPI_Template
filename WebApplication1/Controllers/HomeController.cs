using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        public ActionResult HtmlTest()
        {
            ViewData["zhh"] = "123";
            ViewBag.qq = "456";
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem()
            {
                Selected = false,
                Text = "zhhj",
                Value = "1",
            });
            list.Add(new SelectListItem()
            {
                Selected = true,
                Text = "wcw",
                Value = "3",
            });
            ViewData["ddList"] = list;
            return View();
        }
    }
}