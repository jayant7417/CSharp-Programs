﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentRecords
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Edit",
                url: "Edit/{id}",
                defaults: new { controller = "Home", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Delete",
                url: "Delete/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Filter",
                url: "Filter",
                defaults: new { controller = "Home", action = "Filter", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Index",
                url: "Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
