﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CleanArchTemplate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // 3 line by Metthew Rinzee
            //routes.LowercaseUrls = true;
            //routes.MapMvcAttributeRoutes();
            //routes.RouteExistingFiles = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Account_default",
            //    url: "Account/{controller}/{action}/{id}",
            //    defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "CleanArchTemplate.BC.AccessControl.Account.Presentation.Controllers" }
            //);


            //routes.MapRoute(
            //    name: "Manage_default",
            //    url: "Manage/{controller}/{action}/{id}",
            //    defaults: new { controller = "Manage", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "CleanArchTemplate.BC.AccessControl.Manage.Presentation.Controllers" }
            //);


            //routes.MapRoute(
            //    name: "Home_default",
            //    url: "Home/{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "CleanArchTemplate.BC.Home.Presentation.Controllers" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CleanArchTemplate.BC.Home.Presentation.Controllers", "CleanArchTemplate.BC.AccessControl.Account.Presentation.Controllers", "CleanArchTemplate.BC.AccessControl.Manage.Presentation.Controllers" }
            );
        }
    }
}
