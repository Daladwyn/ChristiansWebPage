using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChristiansWebPage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                               
            // /home/about
            routes.MapRoute("About",
                "About/{name}",
                new { controller = "Home", action = "About", name = UrlParameter.Optional });

            // /home/contact
            routes.MapRoute("Contact",
                "Contact/{name}",
                new { controller = "Home", action = "Contact", name = UrlParameter.Optional });

            // /home/projects
            routes.MapRoute("Projects",
                "Projects/{name}",
                new { controller = "Home", action = "Projects", name = UrlParameter.Optional });

            // Home/FeverCheck
            routes.MapRoute("FeverCheck",
                "FeverCheck/{BodyTemperature}",
                new { controller = "Home", action = "FeverCheck", BodyTemperature = UrlParameter.Optional });
            // Home/GuessingGame
            routes.MapRoute("GuessingGame",
                "GuessingGame/{GuessANumber}",
                new { controller = "Home", action = "GuessingGame", GuessANumber = UrlParameter.Optional });
            
            // /home/percapita
            routes.MapRoute("PerCapita",
                "PerCapita/{action}/{id}",
                new { controller = "PerCapita", action = "Index", id = UrlParameter.Optional });

            // Home/percapita by Ajax
            routes.MapRoute("PerCapitaByAjax",
                "PercapitaByAjax/{action}/{id}",
                new { controller = "PerCapitaByAjax", action = "Index", id = UrlParameter.Optional });

            // /home/index
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );
        }
    }
}
