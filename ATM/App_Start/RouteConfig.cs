﻿using System.Web.Mvc;
using System.Web.Routing;

namespace ATM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* routes.MapRoute(
                           name: "Serial Number",
                           url: "serial",
                           defaults: new { controller = "Home", action = "Serial" }
                       );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
