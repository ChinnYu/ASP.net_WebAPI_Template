using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //系統默認的異常處理過濾器，如果使用自定義異常處理，要將如下代碼刪除
            filters.Add(new HandleErrorAttribute());
            
            //在全局中註冊過濾器，則所有控制器的所有行為，都會執行這個過濾器
            // filters.Add(new MyAuthorization());
            
            // filters.Add(new MyException());
            
            
            
        }
    }
}