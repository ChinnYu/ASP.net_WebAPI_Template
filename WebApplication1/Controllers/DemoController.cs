using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Say()
        {
            return Content("abc");
        }
        
        public ActionResult Redirect()
        {
            return Redirect(Url.Action("Index","Home"));
        }
        
        public ActionResult JsonTest()
        {
            Person p =new Person()
            {
                Qq = "10",
            };
            return Json(p,JsonRequestBehavior.AllowGet);
        }
        
        //第一種方式:Request["key"]的方式接收參數
        public ActionResult Add()
        {
            int id = int.Parse(Request["id"]);
            ViewBag.Id = id;
            return View();
        }

        //第二種方式:自動裝配
        //如果要實現行為的重載，要滿足兩個條件，1.參數不同，2.請求類型不同
        [HttpPost]
        public ActionResult Add(int id)
        {
            ViewBag.Id2 = id;
            return View();
        }
        
        public string Add2()
        {
            return "123";
        }
        
        //自動裝配:可以完成自定義類型的參數的自動裝配
        public ActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPerson(Person person)
        {
            ViewData.Model = person;
            return View("AddPerson1");
        }
        
        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult CalcAdd(int calc1, int calc2)
        {
            int sum = calc1 + calc2;
            return Content(sum.ToString());
        }
        
        public ActionResult CalcAdd1(int calc1, int calc2)
        {
            int sum = calc1 + calc2;
            var temp = new
            {
                Sum = sum
            };
            return Json(temp,JsonRequestBehavior.AllowGet);
        }
    }
}