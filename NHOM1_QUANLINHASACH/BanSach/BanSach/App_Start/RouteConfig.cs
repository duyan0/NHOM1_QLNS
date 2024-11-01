﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BanSach
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
        name: "ProductDetails",
        url: "SanPhams/ProductList/{id}",
        defaults: new { controller = "SanPhams", action = "ChiTiet" }
    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SanPhams", action = "TrangChu", id = UrlParameter.Optional }
            );
        }
    }
}
