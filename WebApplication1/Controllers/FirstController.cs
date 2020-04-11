using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FirstController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// /First/IndexId/3 id是路由解析出來的
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ViewResult IndexId(int id)
        {
            return View();
        }
        
        public ViewResult IndexIdNull(int? id)
        {
            return View();
        }

        public string StringName(string name)
        {
            return $"This is {name}";
        }
        
        public string StringJson(string name)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new {Id=123,Name = name});
        }
        
        public JsonResult Json(int id, string name, string remark)
        {
            return new JsonResult()
            {
                Data = new
                {
                    Id = id,
                    Name = name ?? "X",
                    Remark = remark ?? "這裡是默認的"
                }
            };
        }

        public FilePathResult FileTest()
        {
            return null;
        }



    }
}