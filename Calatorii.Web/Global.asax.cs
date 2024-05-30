using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Calatorii.BusinessLogic.DBModel;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace Calatorii.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Configurare baza de date
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Calatorii.BusinessLogic.DBModel.AppContext>());

            // Set up Unity dependency injection
            var container = new UnityContainer();
            RegisterTypes(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterTypes(IUnityContainer container)
        {
            // Register your types here
            container.RegisterType<Calatorii.BusinessLogic.DBModel.AppContext, Calatorii.BusinessLogic.DBModel.AppContext>(new HierarchicalLifetimeManager());
            // You can register other dependencies here if needed
        }
    }
}
