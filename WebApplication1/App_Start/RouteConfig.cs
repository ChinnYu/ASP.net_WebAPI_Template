using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //自定義路由規則的要求:小範圍寫在前，大範圍寫在後
            //22020-1-1-1
            routes.MapRoute(
                name: "NewsShow",
                url: "{year}-{month}-{day}-{id}",
                defaults: new {controller = "News", action = "Show"},
                constraints: new
                {
                    year="^\\d{4}$",
                    month = "^\\d{1,2}$",
                    day = "^\\d{1,2}$",
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
            
            
        }
    }
}