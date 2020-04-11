using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}