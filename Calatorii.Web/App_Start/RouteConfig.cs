using System.Web.Mvc;
using System.Web.Routing;

namespace Calatorii.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "about/{action}/{id}",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Travel",
                url: "travel/{action}/{id}",
                defaults: new { controller = "Travel", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Trip",
                url: "trip/{action}/{id}",
                defaults: new { controller = "Trip", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "History",
                url: "history/{action}/{id}",
                defaults: new { controller = "History", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Team",
                url: "team/{action}/{id}",
                defaults: new { controller = "Team", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Review",
                url: "review/{action}/{id}",
                defaults: new { controller = "Review", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "login/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Register",
                url: "register/{action}/{id}",
                defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
