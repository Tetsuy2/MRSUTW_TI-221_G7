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
<<<<<<< HEAD
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
            );

            routes.MapRoute(
                name: "Register",
                url: "register/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Register", action = "Register", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin",
                url: "admin/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Manager",
                url: "manager/{action}/{id}",
                defaults: new { controller = "Manager", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Job",
                url: "job/{action}/{id}",
                defaults: new { controller = "Job", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Questions",
                url: "questions/{action}/{id}",
                defaults: new { controller = "Questions", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Map",
                url: "map/{action}/{id}",
                defaults: new { controller = "Map", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LogOut",
                url: "logout/{action}/{id}",
                defaults: new { controller = "LogOut", action = "Index", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional }
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
