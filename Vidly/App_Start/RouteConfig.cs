using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* CONVENTION ROUTING
            //most specifit to general route
            routes.MapRoute(
                "MovieByReleaseDate",
                "movie/released/{year}/{month}",
                new { controller = "Movie", action = "ByReleaseDate" },
                new { year = @"2015|2016", month = @"\d{2}" });  // digit 4; digit 2
            */
            //default route

            //Attribute routing
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
